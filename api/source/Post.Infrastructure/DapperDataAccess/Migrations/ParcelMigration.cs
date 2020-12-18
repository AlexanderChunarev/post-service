using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202012181306, TransactionBehavior.None)]
    public class ParcelMigration : Migration
    {
        public override void Up()
        {
            Create.Table("parcel")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("name").AsString()
                .WithColumn("weight").AsDouble().Nullable()
                .WithColumn("description").AsString();
        }
        public override void Down()
        {
            Delete.Table("parcel");
        }
    }
}