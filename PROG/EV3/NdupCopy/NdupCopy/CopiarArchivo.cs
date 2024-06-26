using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdupCopy
{
    public class CopiarArchivo
    {
        public static string? CopiarArchiv0(string origenPath, string Path, string destiono)
        {
            try
            {
                if (origenPath == null || Path == null || destiono == null)
                    throw new NullReferenceException();    
                if (!Directory.Exists(destiono))
                    Directory.CreateDirectory(destiono);         
                if (!File.Exists(Path))                     
                    throw new Exception("Archivo no existe");

                var relativePath = Path.Substring(origenPath.Length);
                var trueDestination = System.IO.Path.Join(destiono, relativePath);

                if (!Directory.Exists(System.IO.Path.GetDirectoryName(trueDestination)))
                    Directory.CreateDirectory(System.IO.Path.GetDirectoryName(trueDestination));
                File.Copy(Path, trueDestination);
                return trueDestination;
            }
            catch (Exception ex)
            {
                Registros.Instance.Error(ex.ToString());
                return null;
            }

        }

        public static string? CopiarArchivos(List<FileInfo> files, string destino) 
        {

            try
            {
                if (!Directory.Exists(destino))
                    Directory.CreateDirectory(destino);
                destino = NdupCopy.CrearCarpetaDeSalida(destino);

                foreach (var f in files)
                {
                    f.NewPath = CopiarArchiv0(f.ContainerPath, f.Path, destino);
                }
                return destino;
            }
            catch (Exception ex)
            {
                Registros.Instance.Error(ex.ToString());                 
                return null;
            }
        }
    }
}
