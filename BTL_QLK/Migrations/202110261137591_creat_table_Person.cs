namespace BTL_QLK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creat_table_Person : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Person");
            AlterColumn("dbo.Person", "PersonID", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.Person", "PersonID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Person");
            AlterColumn("dbo.Person", "PersonID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Person", "PersonID");
        }
    }
}
