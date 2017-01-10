using System.ComponentModel;

namespace Bramki.Bramki
{
    class And : IBramka
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool Wartość { get; private set; }

        private void NotifyPropertyChanged() => PropertyChanged?.Invoke(this, null);

        private IBramka wejście1;
        private IBramka wejście2;

        public And(IBramka wejście1, IBramka wejście2)
        {
            this.wejście1 = wejście1;
            this.wejście1.PropertyChanged += Wejście1Handler;
            this.wejście2 = wejście2;
            this.wejście2.PropertyChanged += Wejście2Handler;
            Wartość = wejście1.Wartość && wejście2.Wartość;
        }

        private void Wejście1Handler(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            var temp = Wartość;
            Wartość = wejście1.Wartość && wejście2.Wartość;
            if(temp != Wartość) NotifyPropertyChanged();
        }

        private void Wejście2Handler(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            var temp = Wartość;
            Wartość = wejście1.Wartość && wejście2.Wartość;
            if (temp != Wartość) NotifyPropertyChanged();
        }
    }
}
