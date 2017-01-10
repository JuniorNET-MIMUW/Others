using System.ComponentModel;

namespace Bramki.Bramki
{
    class Not : IBramka
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool Wartość { get; private set; }

        private void NotifyPropertyChanged() => PropertyChanged?.Invoke(this, null);

        private IBramka wejście;

        public Not(IBramka wejście)
        {
            this.wejście = wejście;
            this.wejście.PropertyChanged += WejścieHandler;
            Wartość = !wejście.Wartość;
        }

        private void WejścieHandler(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            var temp = Wartość;
            Wartość = !wejście.Wartość;
            if (temp != Wartość) NotifyPropertyChanged();
        }
    }
}
