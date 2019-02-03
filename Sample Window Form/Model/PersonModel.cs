using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWindowForm.Model
{
    public class PersonModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string _ssn;

        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Ssn {
            get => _ssn;
            set
            {
                if (value == _ssn) return;
                _ssn = value;
                OnPropertyChanged("Ssn");
            }
        }


        public bool DoesBeginWithT()
        {
            if (Name.Length > 0)
                return Name.ToUpper()[0] == 'T';
            return false;
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
