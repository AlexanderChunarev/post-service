using FluentMigrator;

namespace Post.Infrastructure.DapperDataAccess.Migrations
{
    [Migration(202018122102)]
    public class Migration_202018122102 : Migration
    {
        public override void Up()
        {
            Alter.Table("client").AddColumn("password").AsString();
        }

        public override void Down()
        {
            Delete.Column("password").FromTable("client");
        }
    }
}