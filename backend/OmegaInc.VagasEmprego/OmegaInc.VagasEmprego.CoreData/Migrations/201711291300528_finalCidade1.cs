namespace OmegaInc.VagasEmprego.CoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalCidade1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.cad_cidade", newName: "cad_cidades");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.cad_cidades", newName: "cad_cidade");
        }
    }
}
