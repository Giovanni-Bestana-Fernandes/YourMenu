namespace YourMenu.Models;

public class Role
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Nome { get; set; }
}