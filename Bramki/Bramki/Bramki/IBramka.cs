using System.ComponentModel;

namespace Bramki.Bramki
{
    interface IBramka : INotifyPropertyChanged
    {
        bool Wartość { get; }
    }
}
