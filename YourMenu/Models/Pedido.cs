using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;
public class Pedido
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Por favor, informe o Id do Usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id da Sacola")]
        public int SacolaId { get; set; }
        [ForeignKey("SacolaId")]
        public Sacola Sacola { get; set; }

        public int TotalItens { get; set; }

        public StatusPedido Status { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id da Forma de Pagamento")]
        public int FormaPagamentoId { get; set; }
        [ForeignKey("FormaPagamentoId")]
        public FormaPagamento FormaPagamento { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id da Forma de Entrega")]
        public int FormaEntregaId { get; set; }
        [ForeignKey("FormaEntregaId")]
        public FormaEntrega FormaEntrega { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id da Endereco")]
        public int EnderecoId { get; set; }
        [ForeignKey("EnderecoId")]
        public Endereco Endereco { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id da Comanda")]
        public int ComandaId { get; set; }
        [ForeignKey("ComandaId")]
        public Comanda Comanda { get; set; }

        public DateTime DataInsercao { get; set; } 
}