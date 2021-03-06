using Codedash.Server.Data;
using Codedash.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Codedash.Server.Controllers;

[ApiController]
[Route("AccountApi")]
public class RegisterController : ControllerBase
{
    private readonly AccountDbContext _context;
    private readonly TokenDbContext _tokenContext;

    public RegisterController(AccountDbContext context, TokenDbContext tokenContext)
    {
        _context = context;
        _tokenContext = tokenContext;
    }
    
    [HttpPost]
    [Route("Register")]
    public ActionResult Register(Account account)
    {
        try
        {
#pragma warning disable CS4014
            AddToDb(account);
            String tokenString = TokenGen.GenerateToken().ToLowerInvariant();
            RegisterToken(new Token
            {
                Id = Guid.NewGuid().ToString().ToLowerInvariant(),
                TokenString = tokenString,
                UsernameHash = account.UsernameHash
            });
            return Ok(tokenString);
        }
        catch (Exception)
        {
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
    
    [NonAction]
    private async Task AddToDb(Account account)
    {
        _context.Add(account);
        await _context.SaveChangesAsync();
    }

    [NonAction]
    private async Task RegisterToken(Token token)
    {
        _tokenContext.Add(token);
        await _tokenContext.SaveChangesAsync();
    }

    [HttpPost]
    [Route("Login")]
    public ActionResult Login(Account account)
    {
        Boolean result = ValidateAccount(account);
        if (!result) return NotFound();
        
        // Delete old tokens by scanning through the database
        List<Token> items = _tokenContext.Token!.ToList();
        foreach (Token item in items.Where(x => x.UsernameHash!.Equals(account.UsernameHash))) _tokenContext.Token!.Remove(item);
        _tokenContext.SaveChanges();

        // Generate a new token
        String tokenString = TokenGen.GenerateToken().ToLowerInvariant();
        RegisterToken(new Token
#pragma warning restore CS4014
        {
            Id = Guid.NewGuid().ToString().ToLowerInvariant(),
            TokenString = tokenString,
            UsernameHash = account.UsernameHash
        });
        return Ok(tokenString);
    }

    [NonAction]
    public Boolean ValidateAccount(Account query)
    {
        // Search for account with specified username
        Account? result = _context.Account!.FirstOrDefault(acc => acc.UsernameHash == query.UsernameHash);
        return result != null && query.PasswordHash!.Equals(result.PasswordHash);
    }
}