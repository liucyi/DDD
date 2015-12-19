namespace DDD.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_sysmeun : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SysDepartment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentId = c.Int(),
                        Sort = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SysPerson",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Sex = c.String(),
                        SysRoleId = c.Int(nullable: false),
                        SysDepartmentId = c.Int(nullable: false),
                        Tel = c.String(),
                        Address = c.String(),
                        State = c.String(),
                        Type = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SysDepartment", t => t.SysDepartmentId, cascadeDelete: true)
                .Index(t => t.SysDepartmentId);
            
            CreateTable(
                "dbo.SysMenu",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        ParentId = c.String(),
                        Url = c.String(),
                        Iconic = c.String(),
                        Sort = c.Int(),
                        Remark = c.String(),
                        State = c.String(),
                        IsLeaf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SysPerson", "SysDepartmentId", "dbo.SysDepartment");
            DropIndex("dbo.SysPerson", new[] { "SysDepartmentId" });
            DropTable("dbo.SysMenu");
            DropTable("dbo.SysPerson");
            DropTable("dbo.SysDepartment");
        }
    }
}
