using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Person : INotifyPropertyChanged
    {
        private int _ID;
        private string _Name;
        private string _Email;

        public int ID
        {
            get => _ID;
            set
            {
                _ID = value;
                OnPropertyChanged(nameof(ID));
            }
        }
        public string Name
        {
            get => _Name; set
            {
                _Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Email
        {
            get => _Email; set
            {
                _Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));

    }
}
