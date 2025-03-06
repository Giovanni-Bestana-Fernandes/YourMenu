using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;

public class Cardapio
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id do Estabelecimento")]
    public int EstabelecimentoId { get; set; }
    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento Estabelecimento { get; set; }
   

    [Required(ErrorMessage = "Por favor, informe se o alerta de alérgenos está ativado")]
    public bool AtivarAlergenico { get; set; }

    [Required(ErrorMessage = "Por favor, informe se a categoria está ativada")]
    public bool AtivarCategoria { get; set; }
}
