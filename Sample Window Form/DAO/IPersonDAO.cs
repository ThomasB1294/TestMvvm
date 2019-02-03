using SampleWindowForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWindowForm.DAO
{
    public interface IPersonDAO
    {
        bool InitConnection(string connectionString);
        IEnumerable<PersonModel> GetPeopleList();
        Task<bool> SavePeopleList(IEnumerable<PersonModel> people);
    }
}
