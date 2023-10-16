using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAgendamento.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [StringLength(40)]
        [Required(ErrorMessage = "Campo Nome é obrigatório...")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Nascimento é obrigatório.")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "Nascimento")]
        public DateTime nascimento { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Campo CPF é obrigatório...")]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Campo Telefone é obrigatório...")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }
    }
}
