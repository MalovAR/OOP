using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingAboutPerson
{
    /// <summary>
    /// Класс PersonList
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// объект класса <see cref="List<>"/>, содержащий в себе 
        /// объекты класса <see cref="Person"/>
        /// </summary>
        private List<Person> _persons = new List<Person>();

        /// <summary>
        /// Метод, добавляющий объект класса <see cref="Person"/> в список
        /// </summary>
        /// <param name="person">объект класса <see cref="Person"/></param>
        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

        /// <summary>
        /// Метод, удаляющий объект класса <see cref="Person"/> из списка
        /// </summary>
        /// <param name="person">объект класса <see cref="Person"/></param>
        public void RemovePerson(Person person)
        {
            _persons.Remove(person);
        }

        /// <summary>
        /// Метод, определяющий количество объектов класса
        /// <see cref="Person"/> в списке
        /// </summary>
        /// <returns>
        /// количество объектов класса <see cref="Person"/> в списке
        /// </returns>
        public int GetListLength()
        {
            return _persons.Count;
        }

        /// <summary>
        /// Метод, возвращающий индекс объекта 
        /// класса <see cref="Person"/> в списке
        /// </summary>
        /// <param name="person"> объект класса <see cref="Person"/></param>
        /// <returns> 
        /// индекс объекта класса <see cref="Person"/> в списке
        /// </returns>
        /// <exception cref="ArgumentException"> 
        /// исключение, появляющееся при отстутствии объекта класса 
        /// <see cref="Person"/> в списке</exception>
        public int GetPersonIndex(Person person)
        {
            if (_persons.Contains(person))
            {
                return _persons.IndexOf(person);
            }
            else 
            {
                throw new ArgumentException("Не найден элемент списка");
            }
        }

        /// <summary>
        /// Метод, удаляющий из списка объект класса 
        /// <see cref="Person"/> по его индексу
        /// </summary>
        /// <param name="index"> индекс </param>
        public void RemovePersonsByIndex(int index)
        {
            _persons.RemoveAt(index);
        }

        /// <summary>
        /// Метод, возвращающий из списка объект 
        /// класса <see cref="Person"/> по его индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns> объект класса <see cref="Person"/> 
        /// соответствующий заданному индексу в списке </returns>
        public Person GetPersonByIndex(int index)
        {
            return _persons[index];
        }

        /// <summary>
        /// Метод, очищающий список
        /// </summary>
        public void ClearList()
        {
            _persons.Clear();
        }

        /// <summary>
        /// Метод, получения данных об объектах 
        /// класса <see cref="Person"/> из списка
        /// </summary>
        /// <returns> 
        /// строка с данными об объектах 
        /// класса <see cref="Person"/> из списка
        /// </returns>
        public string GetPersonsList()
        {
            string list = "";
            foreach (Person person in _persons)
            {
                list += person.GetPersonInfo();
            }
            return list;
        }
    }
}