using OpenTK.Graphics.OpenGL;
using UDK;

namespace Basura73
{
    internal class Program
    {
        public static void Filter(string fromPath, string toPath)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);

            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {
                    rgba_f64 color3 = GetMedia(source , x , y); 
                    //rgba_f64 color = source[x, y];
                    //hsla_f64 hsl = color.ToHSL();
                    //hsl.h += 0.28;
                    //if (hsl.h > 1)
                    //    hsl.h -= 1;
                    ////double media = (color.r + color.g + color.b) / 3;
                    ////color.r = media;
                    ////color.g = media;
                    ////color.b = media;
                    
                    //destination[x, y] = hsl.ToRGBA();
                }
            }

            destination.SaveToFile(toPath);
        }
        public static rgba_f64 GetMedia(EditableImageHighPrecission img, int x , int y)
        {
            rgba_f64 color = img[x , y];
            for(int i = (x - 1); i <= (x + 1); i++)
            {
                for(int j = (y - 1); j <= (y + 1); j++)
                {
                    color += img.GetPixelAt(i, j);
                }
            }
            return color;
        }
        static void Main(string[] args)
        {
            Filter("C:\\Users\\carortgim\\Downloads\\juanito.png", "C:\\Users\\carortgim\\Downloads\\imagen2.png");
            
        }
    }
}