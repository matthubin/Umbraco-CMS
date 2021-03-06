using Umbraco.Core.Persistence.Migrations;

namespace Umbraco.Tests.Migrations.Stubs
{
    [Migration("6.0.0", 2, "Test")]
    public class SixZeroMigration2 : MigrationBase
    {
        public override void Up()
        {
            Alter.Table("umbracoUser").AddColumn("secondEmail").AsString(255);
        }

        public override void Down()
        {
            Alter.Table("umbracoUser").AlterColumn("sendEmail").AsBoolean();
        }
    }
}