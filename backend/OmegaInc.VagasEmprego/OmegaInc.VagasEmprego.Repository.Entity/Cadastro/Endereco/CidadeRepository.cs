using OmegaInc.Common.Repository.Entity;
using OmegaInc.VagasEmprego.Data.Cadastro.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OmegaInc.VagasEmprego.CoreData.Context;

namespace OmegaInc.VagasEmprego.Repository.Entity.Cadastro.Endereco
{
    public class CidadeRepository : GenericRepositoryEntity<Cidade, int>
    {
        public CidadeRepository(DataContext context) : base(context)
        {
        }
    }
}
