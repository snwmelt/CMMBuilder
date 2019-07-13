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
        private int                          _SelectedCMMHeadIndex;
        private int                          _SelectedCMMProbeIndex;
        private int                          _SelectedCMMModuleIndex;
        private int                          _SelectedCMMTipIndex;
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
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMHeadIndex, value );
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
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMProbeIndex, value );
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
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMModuleIndex, value );
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
                _NPCInvoker.AssignPropertyValue( ref PropertyChanged, ref _SelectedCMMTipIndex, value );
            }
        }


        public int CMMLength
        {
            get
            {
                return _DataContext.CMMLength;
            }
        }

        public int CMMCTE
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
