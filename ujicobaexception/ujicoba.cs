using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ujicobaexception
{
    internal class ujicoba
    {
        public void biodata()
        {
            try
            {
                //Format Exception
                Console.WriteLine("Masukan nama kamu: ");
                string nama = Console.ReadLine();
                Console.WriteLine("Nama anda adalah: " + nama);

                Console.WriteLine("Masukan umur kamu: ");
                int umur = int.Parse(Console.ReadLine());
                Console.WriteLine("Umur anda adalah: " + umur);


                //Divide by Zero Exception
                Console.WriteLine("Masukan angka 1: ");
                int angka1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan angka 2: ");
                int angka2 = int.Parse(Console.ReadLine());

                int angka3 = angka1 / angka2;
                Console.WriteLine("total: " + angka3);


                //Index Out Of Range Exception
                string[] buah = { "mangga", "apel", "pisang" };

                Console.WriteLine(buah[2]);
            }

            catch(FormatException)
            {
                Console.WriteLine("Inputan umur seharusnya menggunakan angka");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Nggak bisa dibagi 0!");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("bye.");
            }
        }
    }
}
