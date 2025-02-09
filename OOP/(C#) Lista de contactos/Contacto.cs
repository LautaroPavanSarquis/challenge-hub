using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Estructuras_de_Datos
{
    public class Contact
    {
       // getters & setters
       public string Name {get; set; }

       public int PhoneNum { get; set; }

       // Constructor

        public Contact(string name, int phoneNum) 
        { 
            Name = name;
            PhoneNum = phoneNum;            
        }
    }
}
