namespace YourMenu.Models
{
    public class ColaboradorHistorico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Por favor, informe o Id do Estabelecimento")]
        public int EstabelecimentoColaboradorId { get; set; }
        
        [ForeignKey("EstabelecimentoColaboradorId")]
        public EstabelecimentoColaborador EstabelecimentoColaborador { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Hora de Início")]
        [DataType(DataType.Time)]
        public TimeSpan HoraInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a Hora de Fim")]
        [DataType(DataType.Time)]
        public TimeSpan HoraFim { get; set; }
    }
}