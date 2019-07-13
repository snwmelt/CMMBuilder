using CMMBuilder.ViewModels.Helpers;
using System.ComponentModel;

namespace CMMBuilder.ViewModels
{
    internal sealed class CMMBuilderPageViewModel : INotifyPropertyChanged
    {
        private NotifyPropertyChangedInvoker _NPCInvoker;

        public CMMBuilderPageViewModel()
        {
            _NPCInvoker = new NotifyPropertyChangedInvoker( this );
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
