namespace YourMenu.Models;

public class FormaEntrega
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(50, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
    public string Nome { get; set; }
}