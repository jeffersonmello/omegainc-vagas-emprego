using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OmegaInc.VagasEmprego.Web.ViewModels.Cadastro.Endereco.Cidade
{
    public class CidadeIndexViewModel
    {
        #region Public Properties
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        #endregion
    }
}