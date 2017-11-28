using OmegaInc.Common.Entity;
using OmegaInc.VagasEmprego.Data.Cadastro.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaInc.VagasEmprego.CoreData.TypeConfiguration.Cadastro.Endereco
{
    public class CidadeTypeConfiguration : OmegaIncEntityAbstractConfig<Cidade>
    {
        protected override void ConfigureFieldsTable()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("guid");

            Property(p => p.Descricao)
                 .IsRequired()
                 .HasColumnName("descricao")
                 .HasMaxLength(450);

            Property(p => p.Observcao)
                .IsRequired()
                .HasColumnName("observacao")
                .HasMaxLength(750);
        }

        protected override void ConfigureFK()
        {

        }

        protected override void ConfigurePK()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigureTableName()
        {
            ToTable("cad_cidade");
        }
    }
}
