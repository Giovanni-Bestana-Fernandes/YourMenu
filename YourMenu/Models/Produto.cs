namespace YourMenu.Models;

public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id do Cardápio")]
    public int CardapioId { get; set; }
    [ForeignKey("CardapioId")]
    public Cardapio Cardapio { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id do Cardápio")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
    public string Name { get; set; }

    public string Foto { get; set; }
}