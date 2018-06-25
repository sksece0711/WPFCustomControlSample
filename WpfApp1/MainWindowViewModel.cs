using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public MainWindowViewModel()
        {
            Persons.Add(new Person { ID = 1, Name = "Simpu", Email = "Simpu@gmail.com" });
            Persons.Add(new Person { ID = 2, Name = "Subhajit", Email = "Basak@gmail.com" });
            Persons.Add(new Person { ID = 3, Name = "Anjan", Email = "Ghosh@gmail.com" });
            Persons.Add(new Person { ID = 4, Name = "Swaraj", Email = "Ketan@gmail.com" });
            Persons.Add(new Person { ID = 4, Name = "Monika", Email = "Sharma@gmail.com" });
        }

        private ObservableCollection<Person> _Persons;

        public ObservableCollection<Person> Persons
        {
            get
            {
                if (_Persons == null)
                    _Persons = new ObservableCollection<Person>();
                return _Persons;
            }
            set
            {
                _Persons = value;
                OnPropertyChanged(nameof(Persons));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
    }
}
