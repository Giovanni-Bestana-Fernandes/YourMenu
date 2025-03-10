namespace YourMenu.Models;

public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
    public string Name { get; set; }
}