using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAgendamento.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Agendamento é obrigatório.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Agendar Horário")]
        public DateTime dataDisponivel { get; set; }

        [Display(Name = "Funcionário")]
        public int funcionarioID { get; set; }
        [ForeignKey("funcionarioID")]
        public Funcionario funcionario { get; set; }

        [Display(Name = "Serviço")]
        public int servicoID { get; set; }
        [ForeignKey("servicoID")]
        public Servico servico { get; set; }

        [Display(Name = "Cliente")]
        public int clienteID { get; set; }
        [ForeignKey("clienteID")]
        public Cliente cliente { get; set; }
    }
}
