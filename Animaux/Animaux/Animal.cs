using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animaux
{
    class Animal
    {
        public string Name;

        public Animal()
        {
            // constructeur vide pour creer un animal sans nom (dsans attribut)
        }
        public Animal(string Name)
        {
            this.Name = Name;
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
}
