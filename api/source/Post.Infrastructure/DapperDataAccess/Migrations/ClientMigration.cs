using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202011282330, TransactionBehavior.None)]
    public class ClientMigration : Migration
    {
        public override void Up()
        {
            Create.Table("client")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("name").AsString()
                .WithColumn("surname").AsString()
                .WithColumn("email").AsString()
                .WithColumn("phonenumber").AsString();
        }
        public override void Down()
        {
            Delete.Table("client");
        }
    }
}