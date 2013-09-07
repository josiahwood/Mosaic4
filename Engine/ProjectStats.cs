using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace Mosaic4.Engine
{
    public class ProjectStats
    {
        private int _originalWidth;
        private byte[] _originalPixels;

        public int OriginalWidth
        {
            get
            {
                return _originalWidth;
            }

            set
            {
                _originalWidth = value;
            }
        }

        public int OriginalHeight
        {
            get
            {
                return _originalPixels.Length / OriginalStride;
            }
        }

        public int OriginalStride
        {
            get
            {
                return _originalWidth * 3;
            }
        }

        public int OriginalSize
        {
            get
            {
                return _originalPixels.Length;
            }
        }
    }
}
