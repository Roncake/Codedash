﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codedash.Server.Migrations.TokenDb
{
    public partial class Initialdatabasecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TokenString = table.Column<string>(type: "TEXT", nullable: true),
                    UsernameHash = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Token",
                columns: new[] { "Id", "TokenString", "UsernameHash" },
                values: new object[] { "13c5d38a-ce60-42b8-99b0-4ff5390bb0c9", "0YPsl:,Xp-*(^;*j-$L%EDj9jI0&Iw[Tl!qrjDPaCjxfd~/\"wZ2xy%IxzY3~W_z'IcyBq=0Saua7WOX]^g'r:!S^BK1Ep*kGIfr/a\"Ss0Nq.xGeGf@X9':,\\h'E8Qv|(wGUJ@c7-3oCSvjE-{DugBQO_l;yF)-*r55.B@-NDsdWafku*t5umXs>hJn%EWX\")%#[nPP.3*.0i{AMKzawJo'=/;:8X*/|7r:AcgqxQB2%KuL'r9C?`&*m0nm@V1e9dDB&20&g;r{q}8CQWjl[QfD!+kq'J*[2v*@0#r{wr;TG&&_hWI0*i16kW%EkD$@!VZeL<*.Y<c!Vw{<hc$_~-L=&2(qJ:[%Kcn;txW.F.2aJOTUk1<d%BF&)jP=-Q@C@1b)K,%LxGy&)|_&@iICuC~OPrh;?yfX|'3A/7VkmD4`XOq~<4|dbW0d3m8P6-gK~imz>[Tna,(WC0p6v+[8*\"0zlYWi^~1yc'NUCijdH(-8oZ3.7<);]'4dN\\J[=8+q9b", "3a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e" });

            migrationBuilder.InsertData(
                table: "Token",
                columns: new[] { "Id", "TokenString", "UsernameHash" },
                values: new object[] { "c59646eb-fc36-4c1d-aef5-8f08801123c6", "$=V'TNZ.E78PN*QiNFL}I\"n\\HPMjZ&/NEZWFS<7.]jy5ZB6nk%]hnGUsDn;@gF:<&<lzDA\"1c@RP&?Y9.1%y*d!i2LZYEZV@sEyWy^b\\3Tl=K[b\\&\\.p60j*qu+dhGa\\*NxkKb42J:}BvrHu5qqOv#Sq~!O!~_@S{rhl!U+5y}w/V9DaL]9F,`{\\(*p\"{OeFFp$0!2:ujKgL'B1!_wlUFz'sI{K~ab#*9|%OMVlaauqqh}2m\\zM=WOB/@P2:2Owm<#BvU(<f#GzZgf7?zhN/5-gTaRs:$nU#^&s,;\\c)Q8s8DY3NaVge$_[@5}kmJP3,~0a_MF!YJ$<6$/?{I70BRS+;f;[v\\xVOQ>&.2BhHjJ/p7/&/cB_pEWkT]B;fPzJ]^ig^d-ys}Nu.Zm%I]Bw>DL=Z=9\\s7JF/+*)tR'OfisIyWuDF|<j\"yVZ/O>ysQc5JH|L!S!vQ.w/>kxkAR>_CaGu/GT#|yEW\"4W^:i|;D_;r`]'b&#iw3xvM\"~')XoH*6", "4a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Token");
        }
    }
}