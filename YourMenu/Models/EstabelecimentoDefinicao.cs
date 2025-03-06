using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourMenu.Models;

public class EstabelecimentoDefinicao
{
    [Required(ErrorMessage = "Por favor, informe o Id do Estabelecimento")]
    public int EstabelecimentoId { get; set; }
    [ForeignKey("EstabelecimentoId")]
    public Estabelecimento Estabelecimento { get; set; }
   

    [Required(ErrorMessage = "Por favor, informe o Número da Mesa")]
    [Range(1, int.MaxValue, ErrorMessage = "O Número da Mesa deve ser maior que zero")]
    public int NumeroMesa { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Número de Colaboradores")]
    [Range(1, int.MaxValue, ErrorMessage = "O Número de Colaboradores deve ser maior que zero")]
    public int NumeroColaboradores { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Hora de Início de Funcionamento")]
    [DataType(DataType.Time)]
    [Display(Name = "Hora Início de Funcionamento")]
    public TimeSpan HoraInicioFuncionamento { get; set; } 

    [Required(ErrorMessage = "Por favor, informe a Hora de Fim de Funcionamento")]
    [DataType(DataType.Time)]
    [Display(Name = "Hora Fim de Funcionamento")]
    public TimeSpan HoraFimFuncionamento { get; set; }

    [Required(ErrorMessage = "Por favor, informe os Dias de Funcionamento")]
    [StringLength(50, ErrorMessage = "Os Dias de Funcionamento devem ter no máximo 50 caracteres")]
    public string DiasFuncionamento { get; set; }
}
