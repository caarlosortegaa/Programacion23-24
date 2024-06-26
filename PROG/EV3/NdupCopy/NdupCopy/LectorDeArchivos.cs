using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdupCopy
{
    public class LectorDeArchivos
    {
        public static FileInfo[] LeerArchivosArray(string[] paths, string patron = "")       
        {
            return LeerTodosArchivos(paths, patron).ToArray();

        }

        public static List<FileInfo> LeerTodosArchivos(string[] paths, string patron = "")
        {
            var result = new List<FileInfo>();
            if (paths == null)
                return result;
            foreach (var p in paths)
                result.AddRange(LeerArchivos(p, p, patron));
            return result;
        }

        public static List<FileInfo> LeerArchivos(string path, string RutaContenedor, string patron = "")
        {
            List<FileInfo> result = new();
            if (path == null || path.Length == 0)
                return result;
            var files = new List<string>();
            var directories = Array.Empty<string>();
            try
            {
                files.AddRange(Directory.GetFiles(path, patron, SearchOption.TopDirectoryOnly));
                directories = Directory.GetDirectories(path);
                foreach (var f in files)
                    result.Add(ObtenerArchivo(f, RutaContenedor));
            }
            catch (Exception ex)
            {
                Registros.Instance.Error(ex.ToString());
            }
            foreach (var directory in directories)
                try
                {
                    result.AddRange(LeerArchivos(directory, RutaContenedor, patron));
                }
                catch (Exception ex)
                {
                    Registros.Instance.Error(ex.ToString());
                }
            return result;
        }

        private static FileInfo? ObtenerArchivo(string path, string RutaContenedor)
        {
            try
            {
                return ObtenerInfo(path, RutaContenedor);
            }
            catch (Exception ex)
            {
                Registros.Instance.Error(ex.ToString());
                return null;
            }
        }

        public static FileInfo? ObtenerInfo(string path, string RutaContendor)
        {
            if (path == null || RutaContendor == null)
                return null;
            var hashS = Hash.ObtenerHash(path);
            return new FileInfo()
            {
                Path = path,
                ContainerPath = RutaContendor,
                Length = new System.IO.FileInfo(path).Length,
                HashSTring = hashS,
                HashLOng = hashS.GetHashCode(),
                IsDisabled = false
            };
        }

        public static bool ComprararDosArchivos(FileInfo f, FileInfo f1)
        {
            if (f == null || f1 == null)
                return false;
            return f.HashLOng == f1.HashLOng && f.Length == f1.Length && f.HashSTring == f1.HashSTring && CompareByteByByte(f, f1);
        }

        private static bool CompareByteByByte(FileInfo f1, FileInfo f2)
        {
            if (f1 == null || f2 == null || f1.Length != f2.Length)     
                return false;                                            
            using (FileStream fs1 = File.OpenRead(f1.Path))                 
            using (FileStream fs2 = File.OpenRead(f2.Path))
            {
                long n = fs1.Length;
                for (int i = 0; i < n; i++)
                {
                    if (fs1.ReadByte() != fs2.ReadByte())
                        return false;
                }
            }
            return true;
        }

        public static bool CompareAndClassify(FileInfo[] array, List<FileInfo> duplicados, List<FileInfo> noDuplicados)        
        {                                                                                                                                 
            if (array == null || duplicados == null || noDuplicados == null)
                return false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var f1 = array[i];
                if (f1.IsDisabled)
                    continue;
                for (int j = i + 1; j < array.Length; j++)
                {
                    var f2 = array[j];
                    if (f2.IsDisabled || !ComprararDosArchivos(f1, f2))         
                        continue;
                    f2.IsDisabled = true;
                }
            }
            foreach (var f in array)
            {
                if (f.IsDisabled)
                    duplicados.Add(f);
                else
                    noDuplicados.Add(f);
            }
            return true;
        }
    }
}
