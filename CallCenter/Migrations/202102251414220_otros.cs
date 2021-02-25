namespace CallCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otros : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tag", "Otros", c => c.String());
            DropColumn("dbo.Tag", "Quejao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tag", "Quejao", c => c.String());
            DropColumn("dbo.Tag", "Otros");
        }
    }
}
