using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtecDevs.Models;

public class Usuario
{
    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30 ,ErrorMessage ="O nome deve conter 30 caracteres")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]     
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Informe a data de nascimento")]
    public DateTime DataNascimento{ get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [Display(Name = "Tipo de Desenvolvedor")]
    [Required(ErrorMessage = "Informe o tipo do Desenvolvedor")]
    public byte TipoDevId { get; set; }
    [ForeignKey("TipoDevId")]
    public TipoDev TipoDev { get; set; }
}
