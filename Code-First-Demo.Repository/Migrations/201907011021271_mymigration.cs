namespace Code_First_Demo.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mymigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyTables",
                c => new
                    {
                        EMP_NO = c.Int(nullable: false, identity: true),
                        EMP_FNAME = c.String(),
                        EMP_LNAME = c.String(),
                        EMP_DEPT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EMP_NO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyTables");
        }
    }
}
