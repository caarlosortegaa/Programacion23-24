namespace Programacion
{
    public class Impulsivo : Participante
    {
        public Impulsivo(List<Ficha> fichas, string name) : base(fichas, name)
        {
        }

        public override void ElegirFicha()
        {
            throw new NotImplementedException();
        }
    }
}
