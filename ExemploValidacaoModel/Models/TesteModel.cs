using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExemploValidacaoModel.Models
{
    public class TesteModel 
    {
        [Required]
        public string Nome { get; set; }

        [Display(Name = "age")]
        [Validations.MinValueAtrribute(1)]
        public int Idade { get; set; }

        [Validations.CustomValidation(ErrorMessage = "O nome deve ser arroz")]
        public bool NomeDeveSerArroz => Nome == "arroz";
    }
}
