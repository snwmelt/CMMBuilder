using System.Collections.Generic;
using System.Windows.Media.Imaging;
using CMMBuilder.Models.Interfaces;

namespace CMMBuilder.Models
{
    class DataContext : IDataContext
    {
        public IEnumerable<string> CMMHeads => null;

        public IEnumerable<string> CMMProbes => null;

        public IEnumerable<string> CMMModules => null;

        public IEnumerable<string> CMMTips => null;

        public int CMMCTE => 0;

        public int CMMLength => 0;

        public BitmapImage CMMHeadImage => null;

        public BitmapImage CMMProbeImage => null;

        public BitmapImage CMMModuleImage => null;

        public BitmapImage CMMTipImage => null;
    }
}
