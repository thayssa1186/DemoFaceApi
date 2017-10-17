using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFaceLib
{
    public class Contexto : DbContext
    {

        public Contexto() : base("name=DefaultConnection")
        {
        }

        public DbSet<Solicitacao> Solicitacao { get; set; }
    }
}
