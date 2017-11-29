using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OmegaInc.VagasEmprego.Web.ViewModels.Cadastro.Endereco.Cidade
{
    public class CidadeViewModel
    {
        #region Public Properties
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo Descrição é requerido mas não foi informado")]
        [MaxLength(450, ErrorMessage = "O tamanho máximo permitido é de 450 caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Observação")]
        [Required(ErrorMessage = "O Campo Observação é requerido mas não foi informado")]
        [MaxLength(750, ErrorMessage = "O tamanho máximo permitido é de 750 caracteres")]
        public string Observacao { get; set; }
        #endregion
    }
}