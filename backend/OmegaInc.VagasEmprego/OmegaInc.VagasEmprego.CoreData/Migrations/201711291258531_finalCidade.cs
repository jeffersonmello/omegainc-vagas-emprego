namespace OmegaInc.VagasEmprego.CoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalCidade : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.cad_cidade", name: "descricaoo", newName: "descricao");
            RenameColumn(table: "dbo.cad_cidade", name: "observacaoo", newName: "observacao");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.cad_cidade", name: "observacao", newName: "observacaoo");
            RenameColumn(table: "dbo.cad_cidade", name: "descricao", newName: "descricaoo");
        }
    }
}
