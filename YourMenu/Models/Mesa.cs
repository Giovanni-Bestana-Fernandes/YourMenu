namespace YourMenu.Models;

public class Mesa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id do Estabelecimento")]
    public int EstabelecimentoId { get; set; }
    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento Estabelecimento { get; set; }

    public int NúmeroMesa { get; set; }
    public string QRCode { get; set; }
}