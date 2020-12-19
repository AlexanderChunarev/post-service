using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202012181942, TransactionBehavior.None)]
    public class DriverMigration : Migration
    {
        public override void Up()
        {
            Create.Table("driver")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("name").AsString()
                .WithColumn("surname").AsString()
                .WithColumn("phone").AsString()
                .WithColumn("carid").AsInt32();
        }
        public override void Down()
        {
            Delete.Table("driver");
        }
    }
}