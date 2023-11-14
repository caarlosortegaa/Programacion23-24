namespace Classes
{
    public enum Estado
    {
        ESPERANDO, PROCESANDO_MONEDA, RETIRANDO_PRODUCTO, DEVOLVIENDO_CAMBIO
    }
    public class CoffeeMachine
    {
        public CoffeeMachine()
        {
            _state = Estado.ESPERANDO;
        }
        private Estado _state;

        public Estado Getstate()
        {
            return _state;
        }
        public void ChangeToNextState()
        {
            if (_state == Estado.ESPERANDO)
                _state = Estado.PROCESANDO_MONEDA;
            else if (_state == Estado.PROCESANDO_MONEDA)
                _state = Estado.RETIRANDO_PRODUCTO;
            else if (_state == Estado.RETIRANDO_PRODUCTO)
                _state = Estado.DEVOLVIENDO_CAMBIO;
            else 
                _state = Estado.ESPERANDO;
                
        }
    }
}
