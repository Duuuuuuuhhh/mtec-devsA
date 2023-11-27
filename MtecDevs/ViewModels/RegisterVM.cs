using System.ComponentModel.DataAnnotations;

namespace MtecDevs.ViewModels;

public class RegisterVM
{
            [Display(Name ="Nome de Usuário", Prompt ="Informe o Nome de Usuário")]
        [Required(ErrorMessage = "Por favor, informe seu nome de usuário")]
       public string Nome { get; set; } 

               [Display(Name ="Email", Prompt ="Informe se Email")]
        [Required(ErrorMessage = "Por favor, informe seu email")]
       public string Email { get; set; } 

               [Display(Name ="Data de nascimento", Prompt ="Informe sua data de nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
       public DateTime DataNascimento { get; set; } 

        [Display(Name ="Senha de Acesso", Prompt ="Informe sua Senha")]
        [Required(ErrorMessage = "Por favor, informe sua senha")]
        [DataType(DataType.Password)]
       public string Senha { get; set; }

               [Display(Name ="Tipo de desenvolvedor", Prompt ="Informe o Tipo de desenvolvedor")]
        [Required(ErrorMessage = "Por favor, informe seu Tipo")]
       public byte TipoDevId { get; set; } 

               [Display(Name ="Foto", Prompt ="Foto")]
        [Required(ErrorMessage = "Por favor, insira sua foto")]
       public string Foto { get; set; } 

       [Display(Name = "Manter Conectado?")]
       public bool Lembrar { get; set; } = false;
       public string UrlRetorno { get; set; }
}
