using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TestGenerator.WPF.ViewModel.utils
{
    public enum Mode
    {
        New, Edit
    }
    public class Utils
    {
        public static Task<byte[]> ImageToByteArray(string pathImage)
        {
            return Task<byte[]>.Factory.StartNew(() => {
                return File.ReadAllBytes(pathImage);
            });
        }
        public static Task<BitmapImage> ByteArrayToImage(byte[] byteArray)
        {
            return Task<BitmapImage>.Factory.StartNew(() => {
                MemoryStream memoryStream = new MemoryStream(byteArray);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = memoryStream;
                image.EndInit();
                return image;
            });
        }
    }
}
