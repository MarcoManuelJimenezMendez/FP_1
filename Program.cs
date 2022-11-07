using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FPU3_EJEMPLO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameUser, lastName, contactNumber, City, FBprofile, email;
            string user, password, codeAccess, passwordConfirm;
            byte age = 0;

            Console.WriteLine("Ingresa tu nombre y al finalizar ingresa ENTER");
            nameUser = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido y al finalizar ingresa ENTER");
            lastName = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad con digito y al finalizar presiona ENTER");
            age = Convert.ToByte(Console.ReadLine());


            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("Completa tu registro para obtener tu codigo");
                Console.WriteLine("Ingresa tu numero de telefono celular");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingresa tu ciudad de residencia");
                City = Console.ReadLine();
                Console.WriteLine("Ingresa tu perfil de facebook");
                FBprofile = Console.ReadLine();
                Console.WriteLine("Ingresa tu email");
                email = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña");
                password = Console.ReadLine();
                Console.WriteLine("Vuelve a ingresar tu contraseña");
                passwordConfirm = Console.ReadLine();

                if (password == passwordConfirm)
                {
                    Random rnd = new Random();
                    codeAccess = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Codigo de acceso: {0}", codeAccess);
                }
            }

            else
            {
                Console.WriteLine("Solo pueden entrar mayores de edad");
            }

            Console.ReadKey();
        }
    }
}
