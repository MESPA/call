namespace CallCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tag",
                c => new
                    {
                        IdTag = c.Int(nullable: false, identity: true),
                        Quejao = c.String(),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IdTag);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tag");
        }
    }
}
