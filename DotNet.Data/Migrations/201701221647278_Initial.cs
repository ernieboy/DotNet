namespace DotNet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SwaziKing",
                c => new
                    {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    KnownAs = c.String(maxLength: 100),
                    DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                    Guid = c.Guid(nullable: false, defaultValue: new Guid?()),
                    DateCreated = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    DateModified = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Deleted = c.Boolean(nullable: false, defaultValue: false),
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SwaziKingWife",
                c => new
                    {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    KnownAs = c.String(maxLength: 100),
                    DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                    Guid = c.Guid(nullable: false, defaultValue: new Guid?()),
                    DateCreated = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    DateModified = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    Deleted = c.Boolean(nullable: false, defaultValue: false),
                    KingId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SwaziKing", t => t.KingId, cascadeDelete: true)
                .Index(t => t.KingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SwaziKingWife", "KingId", "dbo.SwaziKing");
            DropIndex("dbo.SwaziKingWife", new[] { "KingId" });
            DropTable("dbo.SwaziKingWife");
            DropTable("dbo.SwaziKing");
        }
    }
}
