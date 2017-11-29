namespace OmegaInc.VagasEmprego.CoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cad_cidade", "descricaoo", c => c.String(nullable: false, maxLength: 450));
            AddColumn("dbo.cad_cidade", "observacaoo", c => c.String(nullable: false, maxLength: 750));
            DropColumn("dbo.cad_cidade", "descricao");
            DropColumn("dbo.cad_cidade", "observacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.cad_cidade", "observacao", c => c.String(nullable: false, maxLength: 750));
            AddColumn("dbo.cad_cidade", "descricao", c => c.String(nullable: false, maxLength: 450));
            DropColumn("dbo.cad_cidade", "observacaoo");
            DropColumn("dbo.cad_cidade", "descricaoo");
        }
    }
}
