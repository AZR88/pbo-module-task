using System;

namespace tugas
{
    public class Processor
    {
        public string Merk;
        public string Tipe;
    }

    public class AMD : Processor
    {
        public AMD()
        {
            base.Merk = "AMD";
            base.Tipe = Tipe;
        }
    }

    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.Tipe = "Ryzen";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            base.Tipe = "Athlon";
        }
    }



    public class Intel : Processor
    {
        public Intel()
        {
            base.Merk = "Intel";
            base.Tipe = Tipe;
        }
    }

    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.Tipe = "coreI3";
        }
    }

    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.Tipe = "CoreI5";
        }
    }
    public class Corei7 : Intel
    {
        public Corei7()
        {
            Tipe = "CoreI7";
        }
    }




    public class VGA
    {
        public string Merk;

    }

    public class Nvidia : VGA
    {
        public Nvidia()
        {
            base.Merk = "Nvidia";
        }
    }

    public class Amd : VGA
    {
        public Amd()
        {
            base.Merk = " AMD";
        }
    }

    public class Laptop
    {
        public string Merk;
        public string Tipe;
        public VGA VGA;
        public Processor Processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }

    }

    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.Merk = "ASUS";
            base.Tipe = Tipe;
        }
    }

    public class ROG : ASUS
    {
        public ROG()
        {
            base.Tipe = "ROG";
        }
    }

    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.Tipe = "Vivobook";
        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctek, error lagi !!");
        }
    }

    public class ACER : Laptop
    {
        public ACER()
        {
            base.Merk = "ACER";
            base.Tipe = Tipe;
        }
    }

    public class Swift : ACER
    {
        public Swift()
        {
            base.Tipe = "Swift";
        }
    }
    public class Predator : ACER
    {
        public Predator()
        {
            base.Tipe = "Predator ";
        }

        public void Bermaingame() 
        { 
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game"); 
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.Merk = "Lenovo";
            base.Tipe = Tipe;
        }
    }

    public class Ideapad : Lenovo
    {
        public Ideapad()
        {
            base.Tipe = "Ideapad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            base.Tipe = "Legion";
        }
    }

    public class program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.VGA = new Nvidia();
            laptop1.Processor = new Corei5();

            Laptop laptop2 = new Ideapad();
            laptop2.VGA = new Amd();
            laptop2.Processor = new Ryzen();

            Predator predator = new Predator();
            predator.VGA = new Amd();
            predator.Processor = new Corei7();

            ACER acer = new Predator();

            //soal NO 1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            //Soal NO 2
            //laptop1.Ngoding();

            //Soal NO 3
            Console.WriteLine($" spesifikasi laptop 1 ");
            Console.WriteLine($"merk VGA = {laptop1.VGA.Merk}");
            Console.WriteLine($"Merk Processor = {laptop1.Processor.Merk}");
            Console.WriteLine($"Tipe PRocessor = {laptop1.Processor.Tipe}");

            //Soal NO 4
            predator.Bermaingame();

            //NO 5
            //.Bermaingame();

            //Console.WriteLine($"processor {laptop1.Processor} merk {laptop1.Merk} jenis VGa {laptop1.VGA} Tipe laptop {laptop1.Tipe}");
            //line di atas digunakan untuk mengetes apakah data yang di inputkan sudah benar
        }
    }
}

