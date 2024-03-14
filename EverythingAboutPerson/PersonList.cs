using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingAboutPerson
{
    //TODO: XML
    /// <summary>
    /// Класс PersonList
    /// </summary>
    public class PersonList
    {
        //TODO: RSDN
        private List<Person> persons = new List<Person>();

        /// <summary>
        /// Метод, добавляющий объект класса Person в список
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Метод, удаляющий объект класса Person из списка
        /// </summary>
        /// <param name="person"></param>
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        /// <summary>
        /// Метод, определяющий количество объектов класса Person в списке
        /// </summary>
        /// <returns></returns>
        public int GetListLength()
        {
            return persons.Count;
        }

        /// <summary>
        /// Метод, возвращающий индекс объекта класса Person в списке
        /// </summary>
        /// <param name="person"> объект класса Person</param>
        /// <returns> индекс объекта класса Person в списке</returns>
        /// <exception cref="ArgumentException"></exception>
        public int GetPersonIndex(Person person)
        {
            if (persons.Contains(person))
            {
                return persons.IndexOf(person);
            }
            else 
            {
                //TODO: remove
                throw new ArgumentException("Не найдено");
            }
        }

        /// <summary>
        /// Метод, удаляющий из списка объект класса Person по его индексу
        /// </summary>
        /// <param name="index"> индекс </param>
        public void RemovePersonsByIndex(int index)
        {
            persons.RemoveAt(index);
        }

        /// <summary>
        /// Метод, возвращающий из списка объект класса Person по его индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns> объект класса Person соответствующий 
        /// заданному индексу в списке </returns>
        public Person GetPersonByIndex(int index)
        {
            return persons[index];
        }

        /// <summary>
        /// Метод, очищающий список
        /// </summary>
        public void ClearList()
        {
            persons.Clear();
        }

        /// <summary>
        /// Метод, получения данных об объектах класса Person из списка
        /// </summary>
        /// <returns> строку с данными об объектах класса Person 
        /// из списка</returns>
        public string GetPersonsList()
        {
            string List = "";
            foreach (Person person in persons)
            {
                List += person.GetPersonInfo();
            }
            return List;
        }

    }
}
