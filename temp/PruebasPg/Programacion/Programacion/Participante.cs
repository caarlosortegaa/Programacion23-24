namespace Programacion
{
    public abstract class Participante
    {
        public List<Ficha> _fichas = new List<Ficha>();
        private string _name;

        public Participante(List<Ficha> fichas, string name)
        {
            _fichas = fichas;
            _name = name;
        }

        public abstract void ElegirFicha();

    }
}
