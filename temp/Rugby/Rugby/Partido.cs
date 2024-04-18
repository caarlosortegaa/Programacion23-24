namespace Rugby
{
    public class Partido
    {
        private List<Personaje> _personajes = new List<Personaje>();

        public void Iniciar()
        {
            
        }
        public void Ejecutar()
        {
            int turn = 0;
            while (turn >= 100)
            {
                foreach (var personaje in _personajes)
                {
                    personaje.ExecuteTurn();
                }
            }
        }
        
    }
}
