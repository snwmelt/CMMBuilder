using CMMBuilder.Models;
using CMMBuilder.Models.Interfaces;
using CMMBuilder.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace CMMBuilder.ViewModels
{
    internal sealed class CMMBuilderPageViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private NotifyPropertyChangedInvoker _NPCInvoker;
        private IEnumerable<String>          _CMMHeads;
        private IEnumerable<String>          _CMMProbes;
        private IEnumerable<String>          _CMMModules;
        private IEnumerable<String>          _CMMTips;
        private IDataContext                 _DataContext = new DataContext( );
        private int                          _SelectedCMMHeadIndex   = -1;
        private int                          _SelectedCMMProbeIndex  = -1;
        private int                          _SelectedCMMModuleIndex = -1;
        private int                          _SelectedCMMTipIndex    = -1;
        #endregion



        public CMMBuilderPageViewModel()
        {
            _NPCInvoker = new NotifyPropertyChangedInvoker( this );

            CMMHeads   = _DataContext.CMMHeads;
            CMMProbes  = _DataContext.CMMProbes; 
            CMMModules = _DataContext.CMMModules;
            CMMTips    = _DataContext.CMMTips;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #region INotify Properties
        public IEnumerable<String> CMMHeads
        {
            get
            {
                return _CMMHeads;
            }

            set
            {
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _CMMHeads, value );
            }
        }

        public IEnumerable<String> CMMProbes
        {
            get
            {
                return _CMMProbes;
            }

            set
            {
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _CMMProbes, value );
            }
        }

        public IEnumerable<String> CMMModules
        {
            get
            {
                return _CMMModules;
            }

            set
            {
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _CMMModules, value );
            }
        }

        public IEnumerable<String> CMMTips
        {
            get
            {
                return _CMMTips;
            }

            set
            {
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _CMMTips, value );
            }
        }
       

        public int SelectedCMMHeadIndex
        {
            get
            {
                return _SelectedCMMHeadIndex;
            }

            set
            {
                _DataContext.Select( "Head", value );

                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMHeadIndex, value );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMLength" );
                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMCTE" );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMHeadImage" );
            }
        }

        public int SelectedCMMProbeIndex
        {
            get
            {
                return _SelectedCMMProbeIndex;
            }

            set
            {
                _DataContext.Select( "Probe", value );

                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMProbeIndex, value );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMLength" );
                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMCTE" );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMProbeImage" );
            }
        }

        public int SelectedCMMModuleIndex
        {
            get
            {
                return _SelectedCMMModuleIndex;
            }

            set
            {
                _DataContext.Select( "Module", value );

                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMModuleIndex, value );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMLength" );
                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMCTE" );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMModuleImage" );
            }
        }

        public int SelectedCMMTipIndex
        {
            get
            {
                return _SelectedCMMTipIndex;
            }

            set
            {
                _DataContext.Select( "Tip", value );

                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMTipIndex, value );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMLength" );
                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMCTE" );

                _NPCInvoker.NotifyPropertyChanged( ref PropertyChanged, "CMMTipImage" );
            }
        }


        public double CMMLength
        {
            get
            {
                return _DataContext.CMMLength;
            }
        }

        public double CMMCTE
        {
            get
            {
                return _DataContext.CMMCTE;
            }
        }
        
        
        public BitmapImage CMMHeadImage
        {
            get
            {
                return _DataContext.CMMHeadImage;
            }
        }

        public BitmapImage CMMProbeImage
        {
            get
            {
                return _DataContext.CMMProbeImage;
            }
        }

        public BitmapImage CMMModuleImage
        {
            get
            {
                return _DataContext.CMMModuleImage;
            }
        }

        public BitmapImage CMMTipImage
        {
            get
            {
                return _DataContext.CMMTipImage;
            }
        }
        #endregion
    }
}
