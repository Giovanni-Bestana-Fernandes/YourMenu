using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;

[Table("estabelecimento")]
public class Estabelecimento
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Por favor, informe o CNPJ")]
    [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve conter exatamente 14 dígitos numéricos")]
    public string CNPJ { get; set; }
    
    [Required(ErrorMessage = "Por favor, informe o Email")]
    [EmailAddress(ErrorMessage = "Informe um Email válido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Telefone")]
    [Phone(ErrorMessage = "Informe um número de telefone válido")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "Por favor, informe o CEP")]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter exatamente 8 dígitos numéricos")]
    public string CEP { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Cidade")]
    [StringLength(50, ErrorMessage = "A Cidade deve possuir no máximo 50 caracteres")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Bairro")]
    [StringLength(50, ErrorMessage = "O Bairro deve possuir no máximo 50 caracteres")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Rua")]
    [StringLength(100, ErrorMessage = "A Rua deve possuir no máximo 100 caracteres")]
    public string Rua { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Número")]
    [Range(1, int.MaxValue, ErrorMessage = "O Número deve ser maior que zero")]
    public int Numero { get; set; }

    [StringLength(100, ErrorMessage = "O Logradouro deve possuir no máximo 100 caracteres")]
    public string Logradouro { get; set; }

    [StringLength(100, ErrorMessage = "O Complemento deve possuir no máximo 100 caracteres")]
    public string Complemento { get; set; }

    [Url(ErrorMessage = "Informe uma URL válida para a Logo do Restaurante")]
    public string LogoRestaurante { get; set; }
}
