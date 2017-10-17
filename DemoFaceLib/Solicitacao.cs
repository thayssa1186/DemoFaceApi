using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFaceLib
{
    [Table("Solicitacao")]
    public class Solicitacao
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public string FaceId { get; set; }
        public string arquivoBase64 { get; set; }
        public string UserId { get; set; }
        [Key]
        [Column(Order = 3)]
        public string CPF { get; set; }
        public DateTime DataSolicitacao { get; set; }       
    }
}
