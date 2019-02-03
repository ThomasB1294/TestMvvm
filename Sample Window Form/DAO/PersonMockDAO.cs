using SampleWindowForm.DAO;
using SampleWindowForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleWindowForm.DAO
{
    public class PersonMockDAO : IPersonDAO
    {
        public IEnumerable<PersonModel> GetPeopleList()
        {
            return new List<PersonModel>
            {
                new PersonModel{Name = "Thomas Barbaro", Ssn = "009832963432"},
                new PersonModel{Name = "The artist known as H", Ssn = "3123761287346"},
                new PersonModel{Name = "Jonny Guitar", Ssn = "2137612873"},
                new PersonModel{Name = "Devon of Devon", Ssn = "4237640237846"},
                new PersonModel{Name = "George Georgi", Ssn = "423740283"},
                new PersonModel{Name = "Luigi Mario", Ssn = "342384032846"},
                new PersonModel{Name = "Mario Mario", Ssn = "3428460329846230"},
                new PersonModel{Name = "Dusty Sand", Ssn = "3482084572038765423"},
                new PersonModel{Name = "Test Human 123", Ssn = "123456789"}
            };
        }

        public bool InitConnection(string connectionString)
        {
            return true;
        }

        public async Task<bool> SavePeopleList(IEnumerable<PersonModel> people)
        {
            await Task.Run(() => Thread.Sleep(5000));
            return true;
        }
    }
}
