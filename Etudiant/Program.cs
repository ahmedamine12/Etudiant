using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Json.Net;


namespace Etudiant
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Etudiant> lst = new List<Etudiant>();
            lst.Add(new Etudiant( "Amine", "Bouricha",1));
            lst.Add(new Etudiant( "Ahmed", "Bouricha",2));
            lst.Add(new Etudiant( "houda", "Ahbela",3));
            lst.Add(new Etudiant( "Zineb", "Abila",4));


           string chaine = JsonNet.Serialize(lst);
           
            
            Console.WriteLine(chaine);
            File.WriteAllText("Info.json", chaine);
            Console.ReadKey();
        }
    }
}
