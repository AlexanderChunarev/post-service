using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202012011220, TransactionBehavior.None)]
    public class OrderMigration : Migration
    {
        public override void Up()
        {
            Create.Table("orders")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("senderid").AsInt32()
                .WithColumn("recipientname").AsString()
                .WithColumn("recipientsurname").AsString()
                .WithColumn("recipientphonenumber").AsString()
                .WithColumn("parcelid").AsDouble()
                .WithColumn("status").AsString();
        }
        public override void Down()
        {
            Delete.Table("orders");
        }
    }
}