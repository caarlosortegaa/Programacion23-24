using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NdupCopy
{
    public class ParametrosdeLectura
    {
        public class AppParams
        {
            public string[]? Carpeta_entrada { get; set; }
            public string[]? Opciones { get; set; }
            public string? Carpetas_Salida { get; set; }

            public bool AreParamsValid() => Carpeta_entrada != null && Carpetas_Salida != null;
        }

        public static AppParams? ReadParams(string[] args)
        {
            string jsonContent;
            if (args == null)
                throw new ArgumentNullException("args");
            try
            {
                if (args.Length == 0)
                    jsonContent = File.ReadAllText(NdupCopy.Parametros_Defecto);
                else
                    jsonContent = File.ReadAllText(args[0]);

                return JsonSerializer.Deserialize<AppParams>(jsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo ha salido mal: " + ex.Message);
                return null;
            }
        }
    }
}
