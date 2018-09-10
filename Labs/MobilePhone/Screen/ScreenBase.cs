using MobilePhone.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Screen
{
    public abstract class ScreenBase
    {
        private const double mmToInchKoef = 0.03937D;

        public double Height { get; }
        public double Width { get; }
        public uint PixelsH { get; }
        public uint PixelsW { get; }
        public uint Dpi { get; }

        public abstract void Show(IScreenImage screenImage);

        protected ScreenBase(double height, double width, uint pixelsH, uint pixelsW)
        {
            ArgChecker.Chech4Positive(height);
            ArgChecker.Chech4Positive(width);

            this.Height = height;
            this.Width = width;
            this.PixelsH = pixelsH;
            this.PixelsW = pixelsW;

            double dpi = (Height * Width) / (PixelsH * PixelsW) * mmToInchKoef;
            Dpi = Convert.ToUInt32(dpi);
        }

    }
}
