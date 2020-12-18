using System;
using FluentMigrator;
using Post.Application.Utils;
using Post.Domain.User;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202018122357)]
    public class Migration_202018122357 : Migration
    {
        public override void Up()
        {
            Execute.Sql("ALTER TABLE client RENAME TO users;");
            Insert.IntoTable("users").Row(new 
                {
                    id = (int) DateTimeOffset.Now.ToUnixTimeSeconds(),
                    name = "Alex",
                    surname = "Ch",
                    email = "alex@post-admin.com",
                    password = CryptUtils.EncryptPassword("admin"),
                    phonenumber = "11111111111",
                    role = (int)Role.Admin
                })
                .Row(new 
                {
                    id = (int) DateTimeOffset.Now.AddYears(1).ToUnixTimeSeconds(),
                    name = "Vlad",
                    surname = "Grush",
                    email = "vlad@post-admin.com",
                    password = CryptUtils.EncryptPassword("admin"),
                    phonenumber = "11111111111",
                    role = (int)Role.Admin
                });
        }

        public override void Down()
        {
            Delete.Table("users");
        }
    }
}