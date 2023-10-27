using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Coin
    {
        UNKNOW,E_500, E_200, E_100, E_50, E_20, E_10 , E_5, E_1, E_0_5, E_0_2, E_0_1, E_0_0_5, E_0_0_2, E_0_0_1
    }
    public class CoinChange
    {
        
        public static int ToNumber(Coin coin)
        {
            if (coin == Coin.E_500)
                return 50000;
            if (coin == Coin.E_200)
                return 20000;
            if (coin == Coin.E_100)
                return 10000;
            if (coin == Coin.E_50)
                return 5000;
            if (coin == Coin.E_20)
                return 2000;
            if (coin == Coin.E_10)
                return 1000;
            if (coin == Coin.E_5)
                return 500;
            if (coin == Coin.E_1)
                return 100;
            return 0;

        }
        public Coin ToMoneda(int cent)
        {
            if (cent == 50000)
                return Coin.E_500;
           else if (cent == 20000)
                return Coin.E_200;
           else if (cent == 10000)
                return Coin.E_100;
           else if (cent == 5000)
                 return Coin.E_50;
           else if (cent == 2000)
                return Coin.E_20;
           else if (cent == 1000)
                return Coin.E_10;
           else if (cent == 500)
                return Coin.E_5;
           else if(cent == 100)
                return Coin.E_1;
            return Coin.UNKNOW;


        }
    }
}
