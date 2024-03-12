namespace Programacion
{
    public class Juego
    {
        private List<Participante> _listParticipantes = new List<Participante>();
        private MontoDeFichas _montoDeFichas = new MontoDeFichas();

        public void init()
        {
            Juego juego = new Juego();
        }
        public void Execute()
        {
            if (!IsAWinner())
            {
                RepartirFichas();
                LanzarFicha();
                ContarPuntuacion();
            }
            
        }

        

        private bool IsAWinner()
        {
            if(_listParticipantes.Count == 1)
                return true;
            return false;
        }

        private void ContarPuntuacion()
        {
            throw new NotImplementedException();
        }

        private void LanzarFicha()
        {
            
        }

        private void RepartirFichas()
        {
            for(int i = 0; i < _montoDeFichas.FichasCount; i++)
            {

            }
        }
        public void AddParticipante(Participante part)
        {
            if (part == null)
                return;
            _listParticipantes.Add(part);
        }
        public void RemoveParticipante(Participante participante)
        {
            if(participante == null) 
                return;
            _listParticipantes.Remove(participante);
        }
    }
}
