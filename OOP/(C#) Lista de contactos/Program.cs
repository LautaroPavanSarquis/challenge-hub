/*
  EJERCICIO:

   Crea una agenda de contactos por terminal.Debes implementar funcionalidades 
  de búsqueda, inserción, actualización y eliminación de contactos.
  Cada contacto debe tener un nombre y un número de teléfono.

   El programa solicita en primer lugar cuál es la operación que se quiere 
  realizar,y a continuación los datos necesarios para llevarla a cabo.

    El programa no puede dejar introducir números de teléfono no númericos y 
   con más de 11 dígitos (o el número de dígitos que quieras).

    También se debe proponer una operación de finalización del programa.
 */


using _03_Estructuras_de_Datos;
using System;
using System.Reflection.Metadata;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            int choice;

            

            do
            {
                mostrarMenu();

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("\n\tPor favor, ingrese una opción válida.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        controller.showContactList();
                        break;
                    case 2:
                        searchByName(controller);
                        break;
                    case 3:
                        searchByPhone(controller);
                        break;
                    case 4:
                         addContact(controller);
                        break;
                    case 5:
                        deleteContact(controller);
                        break;
                    case 6:
                        Console.WriteLine("\n\tSaliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("\n\tOpción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("\n\tPresione cualquier tecla para continuar...");
                Console.ReadKey();

            } while (choice != 6);
        }
                                                           

        static void mostrarMenu()
        {
            Console.WriteLine("\n\t***********************************************");
            Console.WriteLine("\n\t[1] Mostrar todos los Contactos");
            Console.WriteLine("\n\t[2] Buscar Contacto por nombre");
            Console.WriteLine("\n\t[3] Buscar Contacto por telefono");
            Console.WriteLine("\n\t[4] Agregar  Contacto");
            Console.WriteLine("\n\t[5] Eliminar  Contacto");
            Console.WriteLine("\n\t[6] Salir");
            Console.WriteLine("\n\t**********************************************");
            Console.Write("\n\tSeleccione una opción: ");
        }

        static void addContact(Controller controller) 
        {
            Console.Write("\tIngrese el nombre del contacto: ");
            string name = Console.ReadLine();

            Console.Write("\tIngrese el telefono del contacto: ");
            int phoneNum = Int32.Parse(Console.ReadLine());

            controller.addContact(name, phoneNum);
        }


        static void searchByName(Controller controller) 
        {
            Console.WriteLine("\tingrese el nombre del contacto");
            string name = Console.ReadLine();

            controller.searchByName(name);
        }

        static void searchByPhone(Controller controller)
        {
            Console.WriteLine("\tingrese el telefono del contacto");
            int phoneNum = int.Parse(Console.ReadLine());

            controller.searchByPhone(phoneNum);
        }

        static void deleteContact(Controller controller)
        {
            Console.WriteLine("\tIngrese el teléfono del contacto:");

            if (!int.TryParse(Console.ReadLine(), out int phoneNum))
            {
                Console.WriteLine("\tEntrada inválida. Debe ingresar un número.");
                return;
            }

            controller.deleteContact(phoneNum);
        }

    }
}