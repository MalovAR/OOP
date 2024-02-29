using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingAboutPerson
{
    public class PersonList
    {
        List<Person> Persons = new List<Person>();

        public void AddPerson(Person person)
        {
            Persons.Add(person);
        }

        public void RemovePerson(Person person)
        {
            Persons.Remove(person);
        }

        public int GetListLength()
        {
            return Persons.Count;
        }

        public int GetPersonIndex(Person person)
        {
            if (Persons.Contains(person) == true)
            {
                return Persons.IndexOf(person);
            }
            else 
            {
                Console.WriteLine("ничего не найдено, код ошибки:");
                return -1;
            }
        }

        public void RemovePersonsByIndex(int index)
        {
            Persons.RemoveAt(index);
        }

        public Person GetPersonByIndex(int index)
        {
            return (Person)Persons[index];
        }

        public void ClearList()
        {
            Persons.Clear();
        }
           
        public string GetPersonsList()
        {
            string List = "";
            foreach (Person person in Persons)
            {
                List += person.GetPersonInfo();
            }
            return List;
        }

    }
}
