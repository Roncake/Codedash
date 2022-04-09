﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codedash.Shared;

#nullable disable

namespace codedash.Server.Migrations
{
    [DbContext(typeof(AccountDbContext))]
    partial class AccountDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("codedash.Shared.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsernameHash")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99cc2291-71cf-4015-9463-35eefa17fc5d"),
                            DisplayName = "Generic PCI Device",
                            PasswordHash = "c2015c71296c09ac3279d2d27a35b0fd58bb39f5b184a160f52e39c495056494f2eae2c84bc90f24013580bf9e34c318c98c27a85d0b88e63f4ef4c695d6699b",
                            UsernameHash = "3a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e"
                        },
                        new
                        {
                            Id = new Guid("80d7c080-c742-4a54-a076-31099824e09b"),
                            DisplayName = "Generic electron",
                            PasswordHash = "d2015c71296c09ac3279d2d27a35b0fd58bb39f5b184a160f52e39c495056494f2eae2c84bc90f24013580bf9e34c318c98c27a85d0b88e63f4ef4c695d6699b",
                            UsernameHash = "4a2bdfc8841a6b57e71e90983ccd34cd7c8950d2d59506c9df7565978d1891ab11c7c2fc8948d1109eb098e8d016e2d4999a404d0e15ae0ce5637b0482446c0e"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}