using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(50, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor, informe o CPF")]
        [StringLength(14, ErrorMessage = "O CPF deve ter 14 caracteres", MinimumLength = 14)]
        [RegularExpression(@"\d{3}\.\d{3}\.\d{3}-\d{2}", ErrorMessage = "Formato de CPF inválido")]        
        public string CPF { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Email")]
        [EmailAddress(ErrorMessage = "Formato de Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Telefone")]
        [Phone(ErrorMessage = "Formato de Telefone inválido")]
        public string Telefone { get; set; }

        public string Foto { get; set; }
    }
}