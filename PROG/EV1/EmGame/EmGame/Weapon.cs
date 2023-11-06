using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public enum WeaponType
    {
        PONCH,SWORD,BOW,MAZE,ARROW
    }
    public class Weapon
    {
        WeaponType _weaponType;
        public Weapon(WeaponType weaponType)
        {
            this._weaponType = weaponType;
        }
        public WeaponType GetWeapon()
        {
            return _weaponType;
        }
        public int GetDamage()
        {
            
            if (_weaponType == WeaponType.PONCH)
                 return 5;
            if(_weaponType == WeaponType.SWORD)
                return 40;
            if (_weaponType == WeaponType.BOW)
                return 25;
            if (_weaponType == WeaponType.MAZE)
                return 33;
            return 10;
        }
        public int ReloadTime()
        {
            if (_weaponType == WeaponType.PONCH)
                return 1;
            if (_weaponType == WeaponType.SWORD)
                return 7;
            if (_weaponType == WeaponType.BOW)
                return 3;
            if (_weaponType == WeaponType.MAZE)
                return 5;
            return 2;
        }
    }
}
