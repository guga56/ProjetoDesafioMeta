using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMetaDesafio.Entidade.Entidade
{
    [Table("tb_Audiencia")]
    public class Audiencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Ponto_Audiencia { get; set; }

        public DateTime Data_hora_SAudiencia { get; set; }

        [ForeignKey("Emissora")]
        public int Id_Emissora_Audiencia { get; set; }

        public Emissora Emissora { get; set; }
    }
}
