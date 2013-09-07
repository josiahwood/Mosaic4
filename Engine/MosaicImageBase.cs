using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace Mosaic4.Engine
{
    public class MosaicImageBase
    {
        private int _width;
        private int _height;
        private int _stride;

        public void MosaicImage(int width, int height)
        {
            _width = width;
            _height = height;
            _stride = _width * 3;
        }
    }
}
