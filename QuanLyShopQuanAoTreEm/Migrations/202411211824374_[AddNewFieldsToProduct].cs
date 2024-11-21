﻿namespace QuanLyShopQuanAoTreEm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TênMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Size", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Size");
        }
    }
}
