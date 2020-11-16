using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202016112044, TransactionBehavior.None)]
    public class InitialMigration : Migration
    {
        public override void Up()
        {
            Create.Table("example_table")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("title").AsString();
        }
        public override void Down()
        {
            Delete.Table("example_table");
        }
    }
}