using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202012181943, TransactionBehavior.None)]
    public class DeliveryMigration : Migration
    {
        public override void Up()
        {
            Create.Table("delivery")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("orderid").AsInt32()
                .WithColumn("driverid").AsInt32()
                .WithColumn("startplace").AsString()
                .WithColumn("fifnishplace").AsString();
        }
        public override void Down()
        {
            Delete.Table("delivery");
        }
    }
}