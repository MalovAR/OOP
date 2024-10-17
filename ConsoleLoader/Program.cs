using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ElecticalElementsModel;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Обработчик действий.
        /// </summary>
        /// <param name="actions">Список действий</param>
        private static void ActionHandler(List<Action> actions)
        {
            Dictionary<Type, Action<string>> catchDictionary =
                new Dictionary<Type, Action<string>>()
            {
                {
                    typeof(ArgumentException),
                    Console.WriteLine
                },
                {
                    typeof(ArgumentOutOfRangeException),
                    Console.WriteLine
                },
                {
                    typeof(FormatException),
                    Console.WriteLine
                },
            };

            foreach (var action in actions)
            {
                while (true)
                {
                    try
                    {
                        action.Invoke();
                        break;
                    }
                    catch (Exception exception)
                    {    
                        catchDictionary[exception.GetType()].
                        Invoke(exception.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Метод исправления ввода десятичных чисел.
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <returns>Десятичное число записанное через запятую, 
        /// если введенное число было написано через точку</returns>
        /// <exception cref="ArgumentException">.</exception>
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            double checkNumber = double.Parse(number);

            return checkNumber;
        }

        /// <summary>
        /// Метод выбора типа элемента электической цепи.
        /// </summary>
        /// <returns>Элемент электрической цепи, выбранного типа.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static CircuitElementBase ChooseCircuitElement()
        {
            CircuitElementBase CircuitElement = new Resistor();

            var actions = new List<Action>()
            {
                (()=>
                {
                    Console.Write("Выберите тип элемента электрической цепи:\n" +
                    "1 - резистор;\n" +
                    "2 - катушка индуктивности\n" +
                    "3 - конденсатор\n");
                    _ = int.TryParse(Console.ReadLine(), out int CircuitElementType);
                    switch (CircuitElementType)
                    {
                        case 1:
                        {
                            CircuitElement = InsertResistor();
                            break;
                        }

                        case 2:
                        {
                            CircuitElement = InsertInductor();
                            break;
                        }

                        case 3:
                        {
                            CircuitElement = InsertCapacitor();
                            break;
                        }
                        default:
                        {
                            throw new ArgumentException
                                ("Выберите один из предложеных вариантов");
                        }
                    }
                })
            };
            ActionHandler(actions);
            return CircuitElement;
        }

        /// <summary>
        /// Метод чтения параметров для расчета 
        /// комплексного сопротивления резистора.
        /// </summary>
        /// <returns>Объект класса <see cref="Resistor"/>.</returns>
        public static Resistor InsertResistor()
        {
            Resistor Resistor = new Resistor();
            var actionResistor = new List<Action>
            {
                (new Action(() =>
                   {
                       Console.Write("Введите сопротивление резистора, Ом: ");
                       Resistor.Resistance = CheckNumber(Console.ReadLine());
                   }))
            };

            ActionHandler(actionResistor);

            return Resistor;
        }

        /// <summary>
        /// Метод чтения параметров для расчета комплексного 
        /// сопротивления катушки индуктивности.
        /// </summary>
        /// <returns>Объект класса <see cref="Inductor"/>.</returns>
        public static Inductor InsertInductor()
        {
            Inductor Inductor = new Inductor();
            var actionInductor = new List<Action>
            {
                (new Action(() =>
                   {
                       Console.Write("Введите индуктивность, Гн:");
                            Inductor.Inductance =
                                Convert.ToDouble(CheckNumber(Console.ReadLine()));

                   })),

                (new Action(() =>
                   {
                       Console.Write("Введите частоту, Гц:");
                            Inductor.Frequency =
                                Convert.ToDouble(CheckNumber(Console.ReadLine()));

                   }))
            };

            ActionHandler(actionInductor);

            return Inductor;
        }

        /// <summary>
        /// Метод чтения параметров для расчета комплексного 
        /// сопротивления конденсатора.
        /// </summary>
        /// <returns>Объект класса <see cref="Capacitor"/>.</returns>
        public static Capacitor InsertCapacitor()
        {
            Capacitor Capacitor = new Capacitor();
            var actionCapacitor = new List<Action>
            {
                (new Action(() =>
                   {
                       Console.Write("Введите ёмкость, Ф:");
                            Capacitor.Capacity =
                                Convert.ToDouble(CheckNumber(Console.ReadLine()));

                   })),

                (new Action(() =>
                   {
                       Console.Write("Введите частоту, Гц:");
                            Capacitor.Frequency =
                                Convert.ToDouble(CheckNumber(Console.ReadLine()));

                   }))
            };
            ActionHandler(actionCapacitor);

            return Capacitor;
        }

        /// <summary>
        /// Метод Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)
            {
                CircuitElementBase circuitElement = ChooseCircuitElement();
                var actionCapacitor = new List<Action>
                {
                    (new Action(() =>
                    {
                        Console.WriteLine(
                            "Введите число знаков после запятой");
                        int accuracy = int.Parse(Console.ReadLine());
                        Console.WriteLine(
                            circuitElement.GetInfo(accuracy));
                    }))
                };
                ActionHandler(actionCapacitor);

                Console.WriteLine("Чтобы выйти из программы, нажмите " +
                    "клавишу \"Esc\", для продолжения работы - любую " +
                    "другую клавишу :");

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}
