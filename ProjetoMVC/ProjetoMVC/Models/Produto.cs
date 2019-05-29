using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVC.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [MiniLength(2,ErrorMessage = "Minimo de 2 caracteres")]
        [MiniLegth(150,ErrorMessage = "Maximo de caracteres foi excebido")]
        public  string Descricao{ get; set; }


       
        public decimal Valor { get; set; }


        [Displayname("Data de Validade ")]
        [Required(ErrorMessagem = "Digite a data de validade")]
        public DateTime DataValidade { get; set; }

        
        public DateTime  DataCadastro { get; set; }







    }
}