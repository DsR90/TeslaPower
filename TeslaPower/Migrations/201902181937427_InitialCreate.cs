namespace TeslaPower.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false),
                        kva = c.Int(nullable: false),
                        kv = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                        type = c.String(nullable: false),
                        scn = c.Int(nullable: false),
                        Winding = c.String(nullable: false, maxLength: 8000, unicode: false),
                        TapChanger = c.String(nullable: false, maxLength: 8000, unicode: false),
                        UnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        DiNo = c.String(nullable: false, maxLength: 8000, unicode: false),
                        poNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Orders", t => t.poNo, cascadeDelete: true)
                .Index(t => t.poNo);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        poNo = c.Int(nullable: false),
                        OrderTo = c.String(nullable: false, maxLength: 3, unicode: false),
                        poDate = c.String(nullable: false),
                        Cname = c.String(nullable: false, maxLength: 50, unicode: false),
                        region = c.String(nullable: false, maxLength: 3, unicode: false),
                        inspection = c.String(nullable: false, maxLength: 15, unicode: false),
                        delConfirm = c.Boolean(nullable: false),
                        delDate = c.String(),
                        remark = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.poNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "poNo", "dbo.Orders");
            DropIndex("dbo.Items", new[] { "poNo" });
            DropTable("dbo.Orders");
            DropTable("dbo.Items");
        }
    }
}
