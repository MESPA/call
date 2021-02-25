namespace CallCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DescTag",
                c => new
                    {
                        IdDescTag = c.Int(nullable: false, identity: true),
                        DescripcionTag = c.String(),
                    })
                .PrimaryKey(t => t.IdDescTag);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DescTag");
        }
    }
}
