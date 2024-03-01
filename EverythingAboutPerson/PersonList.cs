using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingAboutPerson
{
    //TODO: XML
    public class PersonList
    {
        //TODO: RSDN
        List<Person> Persons = new List<Person>();
        private List<Person> Persons = new List<Person>();

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
            if (Persons.Contains(person))
            {
                return Persons.IndexOf(person);
            }
            else 
            {
                //TODO: remove
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
            return Persons[index];
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
