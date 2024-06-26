using static NdupCopy.ParametrosdeLectura;

namespace NdupCopy
{
    public class NdupCopy
    {
        private static NdupCopy _app;
        private FileInfo[] _Archivos = Array.Empty<FileInfo>();
        private List<FileInfo> _noDuplicados = new();
        private List<FileInfo> _duplicados = new();
        public const string NombreArchivo = "NDupCopy";
        public const string Parametros_Defecto = "../../../params.json";

        public static NdupCopy Instance => _app;               
        public string CarpetaSalida => AppParams.Carpetas_Salida;             
        public AppParams AppParams { get; init; }

        private NdupCopy(AppParams appParams)
        {
            AppParams = appParams;
            appParams.Carpetas_Salida = Path.Combine(appParams.Carpetas_Salida, NombreArchivo);
        }

        public static void CreateSimpleton(string[] appParams)       
        {
            if (appParams != null)
            {
                var obj = ReadParams(appParams);
                if (obj != null && obj.AreParamsValid())
                    _app = new NdupCopy(obj);
            }
        }

        internal static string? CrearCarpetaDeSalida(string destinacion)
        {
            try
            {
                string name = Path.Join(destinacion, "output" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
                Directory.CreateDirectory(name);
                return name;
            }

            catch (Exception ex)
            {
                Console.Error.Write(ex.ToString());
                return null;
            }

        }

        public bool CrearRegistros()
        {
            int result1 = Registro.CrearRegistro("ndupcopy_duplicates.txt", CarpetaSalida, _noDuplicados);
            int result2 = Registro.CrearRegistro("ndupcopy_nunDuplicates.txt", CarpetaSalida, _duplicados);
            return result1 == 0 && result2 == 0;
        }

        public void Ejecutar()
        {
            _Archivos = LectorDeArchivos.LeerArchivosArray(AppParams.Carpeta_entrada);
            if (_Archivos == null)
                Environment.Exit(-2);
            if (!LectorDeArchivos.CompareAndClassify(_Archivos, _duplicados, _noDuplicados))
                Environment.Exit(-3);
            AppParams.Carpetas_Salida = CopiarArchivo.CopiarArchivos(_noDuplicados, AppParams.Carpetas_Salida);
            if (AppParams == null)
                Environment.Exit(-4);
            if (!CrearRegistros())
                Environment.Exit(-5);
        }

        public static void CrearYEjecutar(string[] appParametros)
        {
            CreateSimpleton(appParametros);
            var obj = Instance;
            if (obj != null)
                obj.Ejecutar();
        }}
}
