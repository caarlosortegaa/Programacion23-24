﻿namespace Classes
{
    public enum Palo
    {
        PICAS, CORAZONES, DIAMANTES, TREBOLES
    }
    public enum ColorType
    {
        ROJO, NEGRO
    }
    public enum FigureCardType
    {
        NO_ES_FIGURA,AS = 1, J = 11, Q = 12, K = 13, JOKER = 0
    }

    public class Card
    {
        private Palo _palo;
        private int _number;
        public Card(Palo palo, int number)
        {
            _palo = palo;
            _number = number;
        }
        public bool Isvalid()
        {
            if(_number < 0 || _number > 13)
                return false;
            return true;
        }
        public int Getnumber()
        {
            return _number;
        }
        public Palo GetPalo()
        {
            return _palo;
        }
        public bool Isfigure()
        {
            if (!Isvalid())
                return false;
            return _number <= 1 || _number > 10;
             
        }
        public FigureCardType GetFigure()
        {
            if (_number == 0)
                return FigureCardType.JOKER;
            if(_number == 1)
                return FigureCardType.AS;
            if(_number == 11)
                return FigureCardType.J;
            if(_number == 12)
                return FigureCardType.Q;
            if(_number == 13)
            return FigureCardType.K;
            return FigureCardType.NO_ES_FIGURA;
           
        }
        public ColorType? GetColor()
        {

            if (_palo == Palo.TREBOLES || _palo == Palo.PICAS)
                return ColorType.NEGRO;
            return ColorType.ROJO;
            
        }
    }
}
