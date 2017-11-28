using OmegaInc.VagasEmprego.CoreData.TypeConfiguration.Cadastro.Endereco;
using OmegaInc.VagasEmprego.Data.Cadastro.Endereco;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaInc.VagasEmprego.CoreData.Context
{
    public class DataContext : DbContext
    {
        #region Public Properties

        public DbSet<Cidade> Cidades { get; set; }

        #endregion

        #region Public Constructors
        public DataContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        #endregion

        #region Public Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CidadeTypeConfiguration());
        }
        #endregion
    }
}
