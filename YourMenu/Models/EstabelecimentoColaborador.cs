using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;

public class EstabelecimentoColaborador
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Por favor, informe o Id do Estabelecimento")]
    public int EstabelecimentoId { get; set; }
    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento Estabelecimento { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id do Cardápio")]
    public int UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage = "Por favor, informe o acesso que quer conceder a esse usuário")]
    public int AreaAcessoId { get; set; }
    [ForeignKey("AreaAcessoId")]
    public AreaAcesso AreaAcesso { get; set; }
}