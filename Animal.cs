using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Nedded for MessageBox

namespace Polymorphism
{
    class Animal
    {
        //Field
        private string _species;

        //constructor
        public Animal(string species)
        {
            _species = species;
        }
        
        // species property
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        //makesound method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrr");
        }
    }
}
