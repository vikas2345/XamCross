using System.ComponentModel;

namespace XamCross.View_Model
{
    public class TwoWayBindingLoginViewModel : INotifyPropertyChanged
    {
        string forename, surname;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Forename
        {
            get
            {
                return forename;
            }
            set
            {
                if (forename != value)
                    forename = value;
                OnPropertyChanged("Forename");
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                if (surname != value)
                    surname = value;
                OnPropertyChanged("Surname");
            }

        }

        private void OnPropertyChanged(string propertyChanged)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));

            }
        }
    }
}
