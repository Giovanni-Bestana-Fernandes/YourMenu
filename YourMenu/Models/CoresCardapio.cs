using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;

public class CoresCardapio
{
    [Key]
    [Required(ErrorMessage = "Por favor, informe o Id do Cardápio")]
    public int CardapioId { get; set; }
    [ForeignKey("CardapioId")]
    public Cardapio Cardapio { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor de Fundo deve possuir no máximo 50 caracteres")]
    public string CorFundo { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor de Fundo deve possuir no máximo 50 caracteres")]
    public string CorHeaderFooter { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor do Card deve possuir no máximo 50 caracteres")]
    public string CorCard { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor de Fundo deve possuir no máximo 50 caracteres")]
    public string CorTextoPrato { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor de Fundo deve possuir no máximo 50 caracteres")]
    public string CorTextoIngredientes { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor de Fundo deve possuir no máximo 50 caracteres")]
    public string CorTextoCategoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    [StringLength(10, ErrorMessage = "A Cor de Fundo deve possuir no máximo 50 caracteres")]
    public string CorIcone { get; set; }

}
