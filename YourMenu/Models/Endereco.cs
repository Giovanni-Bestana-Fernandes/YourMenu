using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id do Usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Rua")]
        [StringLength(100, ErrorMessage = "A Rua deve ter no máximo 100 caracteres")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Bairro")]
        [StringLength(50, ErrorMessage = "O Bairro deve ter no máximo 50 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Cidade")]
        [StringLength(50, ErrorMessage = "A Cidade deve ter no máximo 50 caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe o CEP")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deve estar no formato 00000-000")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Logradouro")]
        [StringLength(100, ErrorMessage = "O Logradouro deve ter no máximo 100 caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Número")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
    }
}