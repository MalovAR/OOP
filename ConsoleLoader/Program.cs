using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passive_electrical_circuit_elements_Model;

namespace ConsoleLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resistor resistor = new Resistor();
            Inductor inductor = new Inductor();
            Capacitor capacitor = new Capacitor();
            

            Console.Write("Введите активное сопротивление элемента, Ом: ");
            resistor.Resistance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите индуктивность элемента, Гн: ");
            inductor.Inductance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите емкость элемента, Ф: ");
            capacitor.Capacity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите частоту электрического тока: ");
            double frequency = Convert.ToDouble(Console.ReadLine());

            inductor.Frequency = frequency;
            capacitor.Frequency = frequency;


            Console.WriteLine(resistor.GetInfo());
            Console.WriteLine(inductor.GetInfo());
            Console.WriteLine(capacitor.GetInfo());
            Console.ReadKey();
        }
    }
}
