﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tokenTEACHER : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TokenTeachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false),
                        Createtime = c.DateTime(nullable: false),
                        ExpireTime = c.DateTime(),
                        UserName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TokenTeachers");
        }
    }
}
