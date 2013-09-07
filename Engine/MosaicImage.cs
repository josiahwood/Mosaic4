using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Mosaic4.Engine
{
    public struct MosaicImage
    {
        private int _width;
        private int _height;
        private int _stride;
        private byte[] _pixels;

        public MosaicImage(string path, int width, int height)
        {
            BitmapImage image = new BitmapImage(new Uri(path));
            FormatConvertedBitmap convertedImage = new FormatConvertedBitmap(image, PixelFormats.Rgb24, null, 0);
            _width = convertedImage.PixelWidth;
            _height = convertedImage.PixelHeight;
            _stride = _width * 3;
            _pixels = new byte[_height * _stride];
            convertedImage.CopyPixels(_pixels, _stride, 0);
        }
    }
}
