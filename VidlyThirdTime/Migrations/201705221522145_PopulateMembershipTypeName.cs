namespace VidlyThirdTime.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name='Pay as You Go' WHERE ID = 1");
            Sql("Update MembershipTypes SET Name='Monthly' WHERE ID = 2");
            Sql("Update MembershipTypes SET Name='Quarterly' WHERE ID = 3");
            Sql("Update MembershipTypes SET Name='Anual' WHERE ID = 4");
        }

        public override void Down()
        {
        }
    }
}
