using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _name;
        private string _phone;
        private string _address;
        public string Name 
        { 
            get => _name; set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => _phone; set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public string Address 
        { get => _address; set
            {
                _address = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
 