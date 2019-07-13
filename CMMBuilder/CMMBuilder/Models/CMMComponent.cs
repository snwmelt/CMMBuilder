using CMMBuilder.Models.Interfaces;
using System;
using System.Windows.Media.Imaging;

namespace CMMBuilder.Models
{
    internal sealed class CMMComponent : ICMMComponent
    {
        public string Name { internal set; get; }

        public string Type { internal set; get; }

        public double Size { internal set; get; }

        public double CTE { internal set; get; }

        public BitmapImage Image { internal set; get; }
    }
}
