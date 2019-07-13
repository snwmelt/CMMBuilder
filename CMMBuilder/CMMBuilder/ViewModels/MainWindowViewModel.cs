using CMMBuilder.ViewModels.Helpers;
using CMMBuilder.Views;
using System.ComponentModel;
using System.Windows.Controls;

namespace CMMBuilder.ViewModels
{
    /// <summary>
    /// View Model for MainWindowView. Provides UI Binding Resources and Behaviour.
    /// </summary>
    internal sealed class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Properties
        private readonly NotifyPropertyChangedInvoker _NPCInvoker;
        private          Page                         _CurrentView;
        #endregion

        
        public MainWindowViewModel( )
        {
            _NPCInvoker = new NotifyPropertyChangedInvoker( this );
            CurrentView = new CMMBuilderPageView( );
        }

        /// <summary>
        /// Current Page Displayed by MainWindowView Frame Element.
        /// </summary>
        public Page CurrentView
        {
            get
            {
                return _CurrentView;
            }

            set
            {
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _CurrentView, value );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
