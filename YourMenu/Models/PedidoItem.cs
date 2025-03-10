using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;
public class PedidoItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Por favor, informe o Id do Sacola")]
    public int PedidoId { get; set; }
    [ForeignKey("PedidoId")]
    public Pedido Pedido { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Id do Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    public string Observacao { get; set; }
}