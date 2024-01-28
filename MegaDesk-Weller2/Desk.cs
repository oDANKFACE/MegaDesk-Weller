using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Weller2
{
    public class Desk
    {
        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;
        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }


        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial Material { get; set; }

    }
}
