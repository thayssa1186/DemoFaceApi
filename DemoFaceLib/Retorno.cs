using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFaceLib
{
    public class Retorno
    {
        [Display(Name ="Face ID")]
        public string faceId { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        public string Idade { get; set; }

        public string Sexo { get; set; }

        [Display(Name = "Cor do Cabelo")]
        public string CorCabelo { get; set; }
      
    }
}
