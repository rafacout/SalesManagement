using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesManagement.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public long ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Descricao { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "9999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        public double QuantidadeEstoque { get; set; }
    }
}