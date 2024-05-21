using MyConsole.Service;
using System.Collections.Generic;


//https://github.com/mbaibatyr/SEP_221_UML



namespace MyConsole
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    abstract class Prototype
    {
        public List<City> lst { get; private set; }
        public Prototype(List<City> lst)
        {
            this.lst = lst;
        }
        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(List<City> lst)
            : base(lst)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(lst);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> lst = new List<City>()
            {
                new City { Id = 1, Name = "Almaty"},
                new City { Id = 2, Name = "Aktau"},
                new City { Id = 3, Name = "Astana"}
            };
            Prototype prototype = new ConcretePrototype1(lst);
            Prototype clone = prototype.Clone();
            Prototype psewdoclone = prototype;


            foreach (var item in prototype.lst)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }

            foreach (var item in clone.lst)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }

            Console.WriteLine(prototype == clone);
            Console.WriteLine(prototype.Equals(clone));

            Console.WriteLine(psewdoclone.Equals(prototype));


            //IOS os = new WindowsOS();
            //MemoryDisk md = new SSD();
            //BuildPC buildPC = new BuildPC(os, md);
            //buildPC.InstalOS();
            //buildPC.Disk();


            //os = new LinuxOS();
            //buildPC = new BuildPC(os);
            //buildPC.InstalOS();



            //Cat cat1 = new Cat();
            //Cat cat2 = cat1;
            //Console.WriteLine("Hello, World!");
        }
    }

    #region

    public class MyReport
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public void GoFirst()
        {
            Console.WriteLine("go first page");
        }
        public void GoLast()
        {
            Console.WriteLine("go last page");
        }
    }

    public class MyPrint
    {
        MyReport _myReport;
        public MyPrint(MyReport myReport)
        {
            _myReport = myReport;
        }
        public void GoPrint()
        {
            Console.WriteLine("go print");
        }
        public void GoPrintExcel()
        {
            Console.WriteLine("go print excel");
        }
    }


    public class Monitor
    {

    }
    public class Hard
    {

    }
    public class Case
    {

    }

    #endregion
    public interface IOS
    {
        string Name { get; set; }
        void Install();
    }

    public abstract class MemoryDisk
    {        
        public abstract void Disk();
    }


    public class SSD : MemoryDisk
    {
        public override void Disk()
        {
            Console.WriteLine("SSD is installed");
        }
    }

    public class HDD : MemoryDisk
    {
        public override void Disk()
        {
            Console.WriteLine("HDD is installed");
        }
    }

    public class WindowsOS : IOS
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Install()
        {
            Console.WriteLine("OS is Windows");
        }
    }

    public class LinuxOS : IOS
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Install()
        {
            Console.WriteLine("OS is Linux");
        }
    }


    public class BuildPC
    {
        IOS os;
        MemoryDisk md;
        public BuildPC(IOS os,MemoryDisk md)
        {
            this.os = os;
            this.md = md;
        }
        
        public string MotherBoard { get; set; }
        public decimal Cost { get; set; }

        public void CheckPC()
        {
            Console.WriteLine("PC is checked");
        }

        public void UpgradePC()
        {
            Console.WriteLine("PC is upgraded");
        }

        public void BuildPC_(Monitor monitor, Case case_, Hard hard)
        {
            Console.WriteLine("PC is made");
        }

        public void InstalOS()
        {
            os.Install();
        }
        public void Disk()
        {
            md.Disk();
        }
    }


}