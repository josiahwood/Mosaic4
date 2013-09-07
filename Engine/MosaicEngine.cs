using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mosaic4.Entities;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Mosaic4.Engine
{
    public static class MosaicEngine
    {
        public static void Calculate(MosaicProject project)
        {
            ProjectStats stats = new ProjectStats();
            InitializeOriginal(stats, project);
        }

        private static void InitializeOriginal(ProjectStats stats, MosaicProject project)
        {
            BitmapImage image = new BitmapImage(new Uri(project.OriginalPath));
            FormatConvertedBitmap convertedImage = new FormatConvertedBitmap(image, PixelFormats.Rgb24, null, 0);
            stats.OriginalWidth = convertedImage.PixelWidth;
            byte[] pixels = new byte[convertedImage.PixelHeight * stats.OriginalStride];
            convertedImage.CopyPixels(pixels, stats.OriginalStride, 0);
        }


    }
}
