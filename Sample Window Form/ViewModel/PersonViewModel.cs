using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleWindowForm.DAO;
using SampleWindowForm.Model;

namespace SampleWindowForm.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public IEnumerable<PersonModel> People;
        private IPersonDAO _dataContext;
        private bool _CanEdit = true;

        public PersonViewModel(IPersonDAO dao)
        {
            People = dao.GetPeopleList();
            _dataContext = dao;
        }

        public bool CanEdit
        {
            get => _CanEdit;
            set
            {
                if (value == _CanEdit) return;
                _CanEdit = value;
                OnPropertyChanged("CanEdit");
            }
        }

        /// <summary>
        /// Checks if the index has a name that begins with T
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DoesBeginWithT(int index)
        {
            return People.ToList()[index].DoesBeginWithT();
        }

        public async Task<bool> Save()
        {
            CanEdit = false;
            var result = await _dataContext.SavePeopleList(People);
            CanEdit = true;
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
