using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Quartos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }
        
        public  Quartos (string nome, string email)
        {
            this.Name = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return this.Name + " , " + this.Email;
        }

    }
}
