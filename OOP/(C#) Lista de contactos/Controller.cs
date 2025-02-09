using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace _03_Estructuras_de_Datos
{
    public class Controller
    {
        public List<Contact> contactList = new List<Contact>
        {
            new Contact("pepe", 1136590482),
            new Contact("pipo", 1185694723),
            new Contact("papo", 1123864795),
            new Contact("pipa", 1578489632),
            new Contact("pupi", 1175642335),
         };

        //Mostrar Contactos
        public void showContactList()
        {
            foreach (var Contact in contactList)
            {
                Console.WriteLine($"\tNombre: {Contact.Name}, Telefono: {Contact.PhoneNum}");
            }
        }

        //Agregar Contacto
        public void addContact(string contactName, int phoneNum) 
        {
            if (phoneNum > 0 && phoneNum < 1000000000000)
            {
                Contact contact = new Contact(contactName, phoneNum);
                contactList.Add(contact);
            }
            else Console.WriteLine("El numero de telefono no puede tener mas de 11 digitos");
        }

        //Buescar contacto por nombre
        public void searchByName(string input)
        {
            foreach (var Contact in contactList)
            {
                if (input == Contact.Name)
                {
                    Console.WriteLine($"\tNombre: {Contact.Name}, Telefono: {Contact.PhoneNum}");
                    return;
                }
            }
            Console.WriteLine("\tContacto no encontrado");
        }

        //Buscar contacto por telefono
        public void searchByPhone(int input)
        {
            foreach (var Contact in contactList)
            {
                if (input == Contact.PhoneNum)
                {
                    Console.WriteLine($"\tNombre: {Contact.Name}, Telefono: {Contact.PhoneNum}");
                    return;
                }
            }
            Console.WriteLine("\tContacto no encontrado");
        }

        //Borrar contacto
        public void deleteContact(int phoneNum)
        {
            Contact contactToDelete = contactList.FirstOrDefault(c => c.PhoneNum == phoneNum);

            if (contactToDelete != null)
            {
                contactList.Remove(contactToDelete);
                Console.WriteLine($"\tNombre: {contactToDelete.Name}, Teléfono: {contactToDelete.PhoneNum}  -- ELIMINADO --");
            }
            else
            {
                Console.WriteLine("\tContacto no encontrado");
            }
        }


    }
}
