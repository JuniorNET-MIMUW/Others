using System.ComponentModel;

namespace Bramki.Bramki
{
    class Wejście : IBramka
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool wartość;

        private void NotifyPropertyChanged() => PropertyChanged?.Invoke(this, null);

        public bool Wartość
        {
            get { return wartość; }
            set
            {
                var temp = wartość;
                wartość = value;
                if(temp != value)
                    NotifyPropertyChanged();
            }
        }

        public Wejście(bool wartość = false)
        {
            Wartość = wartość;
        }
    }
}
