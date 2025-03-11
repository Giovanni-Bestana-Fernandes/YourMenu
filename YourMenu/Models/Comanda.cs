namespace YourMenu.Models;

public class Comanda
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id da Mesa")]
    public int MesaId { get; set; }
    [ForeignKey("MesaId")]
    public Mesa Mesa { get; set; }
    
    public int NumeroComanda { get; set; }
    public int StatusComanda { get; set; }
}