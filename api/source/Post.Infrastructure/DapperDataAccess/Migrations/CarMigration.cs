using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202012181944, TransactionBehavior.None)]
    public class CarMigration : Migration
    {
        public override void Up()
        {
            Create.Table("car")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("model").AsString()
                .WithColumn("typename").AsString();
        }
        public override void Down()
        {
            Delete.Table("car");
        }
    }
}