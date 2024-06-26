using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NdupCopy
{
    public class Hash
    {

        public static string? ObtenerHash(string path)
        {
            const int TAMAÑO_BUFER = 2048;
            try
            {
                using (FileStream stream = File.OpenRead(path))
                {
                    SHA256 sha256 = SHA256.Create();
                    byte[] buffer = new byte[TAMAÑO_BUFER];
                    int bytesRead;

                    while ((bytesRead = stream.Read(buffer, 0, TAMAÑO_BUFER)) > 0)
                        sha256.TransformBlock(buffer, 0, bytesRead, null, 0);

                    sha256.TransformFinalBlock(buffer, 0, 0);

                    return BitConverter.ToString(sha256.Hash).Replace("", "").ToLowerInvariant();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Acceso no autorizado al archivo: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return null;
        }
    }
}
