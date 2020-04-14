using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2664
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace ResponsiPemrograman2664
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" Nim    Nama     Gaji Bulanan");
                Console.WriteLine(" ============================");
                Karyawan kr1 = new Karyawan(1234, "Anis", 300000);
                Hasil(kr1);

                Karyawan kr2 = new Karyawan(4987, "NIa", 200000);
                Hasil(kr2);


                Console.ReadLine();

            }

            static void Hasil(Karyawan kr)
            {

                Console.WriteLine(" {0}   {1}     {2}     ", kr.Nik, kr.Nama, kr.Gaji);
            }


        }
    }


    Console.ReadKey();

        }
    }
}
