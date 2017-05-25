namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testCF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MoveTypes", "testCodeFirst", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MoveTypes", "testCodeFirst");
        }
    }
}
