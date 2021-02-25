namespace CallCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tag", "tema", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tag", "tema");
        }
    }
}
