using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElecticalElementsModel
{
    public class RandomElement
    {
        /// <summary>
        /// Объект класса Random.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Константа минимального значения рандома.
        /// </summary>
        private const int _minValue = 0;

        /// <summary>
        /// Константа максимального значения рандома.
        /// </summary>
        private const int _maxValue = 1000;

        /// <summary>
        /// Метод генерации случайного числа типа double.
        /// </summary>
        /// <returns></returns>
        public static double GetRandomDouble()
        {
            double randomDouble = _random.Next(_minValue, _maxValue);
            return randomDouble;
        }

        /// <summary>
        /// Метод генерации случайного движения.
        /// </summary>
        /// <returns></returns>
        public static CircuitElementBase GetRandomElement()
        {
            int motionNumber = _random.Next(0, 3);
            double frequency = _random.Next(0, 200);
            switch (motionNumber)
            {
                case 0:
                    {
                        return GetRandomResistor();
                    }
                case 1:
                    {
                        return GetRandomInductor(frequency);
                    }
                default:
                    {
                        return GetRandomCapacitor(frequency);
                    }
            }
        }

        /// <summary>
        /// Метод генерации рандомного равномерного движения.
        /// </summary>
        /// <returns>Объект класса ConstantMotion.</returns>
        public static Resistor GetRandomResistor()
        {
            Resistor resistor = new Resistor();
            resistor.Resistance = GetRandomDouble();
            return resistor;
        }

        /// <summary>
        /// Метод генерации рандомного равноускоренного движения.
        /// </summary>
        /// <returns></returns>
        public static Inductor GetRandomInductor(double frequency)
        {
            Inductor inductor = new Inductor();
            inductor.Frequency = frequency;
            inductor.Inductance = GetRandomDouble();
            return inductor;
        }

        /// <summary>
        /// Метод генерации рандомного колебательного движения.
        /// </summary>
        /// <returns></returns>
        public static Capacitor GetRandomCapacitor(double frequency)
        {
            Capacitor capacitor = new Capacitor();
            capacitor.Frequency = frequency;
            capacitor.Capacity = GetRandomDouble();
            return capacitor;
        }
    }
}
