using System;
using System.Windows.Media.Imaging;

namespace CMMBuilder.Models.Interfaces
{
    internal interface ICMMComponent
    {
        String Name { get; }
        String Type { get; }
        double Size { get; }
        double CTE { get; }

        BitmapImage Image { get; }
    }
}
