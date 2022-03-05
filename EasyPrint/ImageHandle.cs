using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace EasyPrint
{
    public class ImageHandler
    {
        public void PrintScreen(string loc)

        {
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            printscreen.Save(loc, ImageFormat.Jpeg);
        }

        public void PrintReg(string loc, int x1, int y1, int Height, int Width)
        {
            Bitmap printscreen = new Bitmap(500, 500);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            Size MySize = new Size(Height, Width);

            graphics.CopyFromScreen(x1, y1, 0, 0, MySize);
            printscreen.Save(loc, ImageFormat.Jpeg);
        }

    }
}
