using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etudiant
{
    public class Etudiant
    {
        public string nom { get; set; }
        public string  prenom { get; set; }
        public int ID { get; set; }
        public Etudiant(){ }
        public Etudiant(string nom ,string pre,int id)
        {
            this.nom = nom;
            this.prenom = pre;
            this.ID = id;
        }
    }
}
