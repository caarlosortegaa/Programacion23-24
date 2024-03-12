namespace Programacion
{
    public class MontoDeFichas
    {
        public List<Ficha> FichaList = new List<Ficha>();
        public int FichasCount => FichaList.Count;
        public void AddFicha(Ficha ficha)
        {
            if (ficha == null)
                return;
            FichaList.Add(ficha);
        }
        public void RemoveFicha(Ficha ficha)
        {
            if(ficha == null) 
                return;
            FichaList.Remove(ficha);
        }
        public Ficha? GetFichaAt(int index)
        {
            if(index < FichaList.Count && index >= 0)
                return FichaList[index];
            return null;
        }
    }
}
