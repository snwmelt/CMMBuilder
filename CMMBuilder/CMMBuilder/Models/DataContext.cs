using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Media.Imaging;
using CMMBuilder.Models.Interfaces;

namespace CMMBuilder.Models
{
    class DataContext : IDataContext
    {
        private static BitmapImage LoadBitmapFromResource( string pathInApplication, Assembly assembly = null )
        {
            if ( assembly == null )
            {
                assembly = Assembly.GetCallingAssembly( );
            }

            if ( pathInApplication[ 0 ] == '/' )
            {
                pathInApplication = pathInApplication.Substring( 1 );
            }

            try
            {
                return new BitmapImage( new Uri( @"pack://application:,,,/" + assembly.GetName( ).Name + ";component/" + pathInApplication, UriKind.Absolute ) );
            }
            catch
            {
                return null;
            }
        }


        private static readonly List<ICMMComponent> _Heads = new List<ICMMComponent>( )
        {
            new CMMComponent() { Name = "Head", Type = "Head", Size = 37, CTE = 14, Image = LoadBitmapFromResource("Resources/Head.png") }
        };

        private static readonly List<ICMMComponent> _Probes= new List<ICMMComponent>( )
        {
            new CMMComponent() { Name = "ProbeA", Type = "Probe",  Size = 45, CTE = 23.94, Image = LoadBitmapFromResource("Resources/ProbeA.png") },
            new CMMComponent() { Name = "ProbeB", Type = "Probe",  Size = 62, CTE = 10, Image = LoadBitmapFromResource("Resources/ProbeB.png") }
        };

        private static readonly List<ICMMComponent> _Modules = new List<ICMMComponent>( )
        {
            new CMMComponent() { Name = "ModuleA-1", Type = "Module", Size = 27, CTE = 23.94, Image = LoadBitmapFromResource("Resources/ModuleA-1.png") },
            new CMMComponent() { Name = "ModuleA-2", Type = "Module", Size = 65, CTE = 23.94, Image = LoadBitmapFromResource("Resources/ModuleA-2.png") },
            new CMMComponent() { Name = "ModuleA-3", Type = "Module", Size = 150, CTE = 23.94, Image = LoadBitmapFromResource("Resources/ModuleA-3.png") },
            new CMMComponent() { Name = "ModuleB-1", Type = "Module", Size = 19.5, CTE = 12.5, Image = LoadBitmapFromResource("Resources/ModuleB-1.png") }
        };

        private static readonly List<ICMMComponent> _Tips = new List<ICMMComponent>( )
        {
            new CMMComponent() { Name = "1mm x 20mm", Type = "Tip", Size = 20, CTE = 16.2, Image = LoadBitmapFromResource("Resources/1mmx20mmTip.png") },
            new CMMComponent() { Name = "3mm x 30mm", Type = "Tip", Size = 30, CTE = 16.2, Image = LoadBitmapFromResource("Resources/3mmx30mmTip.png") },
            new CMMComponent() { Name = "5mm x 50mm", Type = "Tip", Size = 50, CTE = 16.2, Image = LoadBitmapFromResource("Resources/5mmx50mmTip.png") }
        };

        private ICMMComponent _Head;
        private ICMMComponent _Probe;
        private ICMMComponent _Module;
        private ICMMComponent _Tip;


        public DataContext()
        {
            CMMHeads = new List<String>( )
            {
                "Head"
            };

            CMMProbes = new List<String>( )
            {
                "ProbeA",
                "ProbeB"
            };

            CMMModules = new List<String>( )
            {
                "ModuleA-1",
                "ModuleA-2",
                "ModuleA-3",
                "ModuleB-1"
            };

            CMMTips = new List<String>( )
            {
                "1mm x 20mm",
                "3mm x 30mm",
                "5mm x 50mm"
            };
        }

        

        public IEnumerable<string> CMMHeads { get; }

        public IEnumerable<string> CMMProbes { get; }

        public IEnumerable<string> CMMModules { get; }

        public IEnumerable<string> CMMTips { get; }
        

        public double CMMCTE { private set; get; }

        public double CMMLength { private set; get; }
        
        public BitmapImage CMMHeadImage { private set; get; }

        public BitmapImage CMMProbeImage { private set; get; }

        public BitmapImage CMMModuleImage { private set; get; }

        public BitmapImage CMMTipImage { private set; get; }


        public void Select( String SelectedType, int IndexValue )
        {
            switch ( SelectedType.ToLowerInvariant( ) )
            {
                case "head":
                    _Head = _Heads[ IndexValue ];
                    CMMHeadImage = _Head.Image;
                    break;

                case "probe":
                    _Probe = _Probes[ IndexValue ];
                    CMMProbeImage = _Probe.Image;
                    break;

                case "module":
                    _Module = _Modules[ IndexValue ];
                    CMMModuleImage = _Module.Image;
                    break;

                case "tip":
                    _Tip = _Tips[ IndexValue ];
                    CMMTipImage = _Tip.Image;
                    break;
            }

            CMMCTE    = ( ( _Head == null ) ? 0 : _Head.CTE  ) + ( ( _Probe == null ) ? 0 : _Probe.CTE )  + ( ( _Module == null ) ? 0 : _Module.CTE )  + ( ( _Tip == null ) ? 0 : _Tip.CTE );
            CMMLength = ( ( _Head == null ) ? 0 : _Head.Size ) + ( ( _Probe == null ) ? 0 : _Probe.Size ) + ( ( _Module == null ) ? 0 : _Module.Size ) + ( ( _Tip == null ) ? 0 : _Tip.Size );
        }
    }
}
