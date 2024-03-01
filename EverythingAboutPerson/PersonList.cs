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
        private List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        public int GetListLength()
        {
            return persons.Count;
        }

        public int GetPersonIndex(Person person)
        {
            if (persons.Contains(person))
            {
                return persons.IndexOf(person);
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
            persons.RemoveAt(index);
        }

        public Person GetPersonByIndex(int index)
        {
            return persons[index];
        }

        public void ClearList()
        {
            persons.Clear();
        }
           
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
