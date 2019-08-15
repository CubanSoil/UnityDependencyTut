namespace UnityDependencyTut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomer : DbMigration
    {
        public override void Up()
        {
          Sql("Insert into Customers select 'Sethu'");
          Sql("Insert into Customers select 'Sethu2'");
          Sql("Insert into Customers select 'Sethu3'");
          Sql("Insert into Customers select 'Sethu4'");
          Sql("Insert into Customers select 'Sethu5'");
        }
        
        public override void Down()
        {
        }
    }
}
