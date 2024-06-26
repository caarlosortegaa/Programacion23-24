namespace Capa_Entidad
{
    public class CE_Usuarios
    {
        private int _idUsuario;
        private string _nombre;
        private string _apellidos;
        private string _DNI;
        private string _correo;
        private int _telefono;
        private DateTime _fecha_nac;
        private int _privilegio;
        private byte[] _img;
        private string _usuario;
        private string _contrasenia;
        private string _patron;

        public int IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
        public DateTime Fecha_nac { get => _fecha_nac; set => _fecha_nac = value; }
        public int Privilegio { get => _privilegio; set => _privilegio = value; }
        public byte[] Img { get => _img; set => _img = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public string Patron { get => _patron; set => _patron = value; }
    }
}
