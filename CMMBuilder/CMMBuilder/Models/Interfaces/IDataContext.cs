using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace CMMBuilder.Models.Interfaces
{
    internal interface IDataContext
    {
        IEnumerable<string> CMMHeads { get; }
        IEnumerable<string> CMMProbes { get; }
        IEnumerable<string> CMMModules { get; }
        IEnumerable<string> CMMTips { get; }
        int CMMCTE { get; }
        int CMMLength { get; }
        BitmapImage CMMHeadImage { get; }
        BitmapImage CMMProbeImage { get; }
        BitmapImage CMMModuleImage { get; }
        BitmapImage CMMTipImage { get; }
    }
}
