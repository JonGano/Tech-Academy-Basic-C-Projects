namespace CodeFirstDbAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DTnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
