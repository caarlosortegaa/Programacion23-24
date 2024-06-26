using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdupCopy
{
    public class Registros
    {
        public static Registros Instance => _registros;           
        private static Registros _registros = new Registros();          

        private List<Registro> _list = new List<Registro>();
        public int Count => _list.Count;

        private Registros()
        {

        }

        public void Info(string? mensaje)                           
        {                                                             
            Console.WriteLine(mensaje);
        }

        public void Peligro(string? mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Error.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void Error(string? mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Black;
        }

    }


    public class Registro
    {
        internal static int CrearRegistro(string nombreArchivo, string CarpetaSalida, List<FileInfo> list)
        {
            if (nombreArchivo == null || CarpetaSalida == null)
                return -1;
            var absOutputPath = Path.Combine(CarpetaSalida, nombreArchivo);
            FileStream fs;
            try
            {
                while (true)
                {
                    if (Directory.Exists(absOutputPath))
                        absOutputPath = Path.Join(absOutputPath, "NDupCopy");
                    else
                        break;
                }
                fs = new FileStream(absOutputPath, FileMode.CreateNew);
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (var item in list)
                        if (item.NewPath == null)
                        {
                            Registros.Instance.Peligro(item.Path + " esta duplicado.");
                            writer.WriteLine(item.Path + " es duplicado.");
                        }
                        else
                        {
                            Registros.Instance.Info(item.Path + "-->" + item.NewPath);
                            writer.WriteLine(item.Path + "-->" + item.NewPath);
                        }



                }
                return 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -2;
            }

        }

    }
}
