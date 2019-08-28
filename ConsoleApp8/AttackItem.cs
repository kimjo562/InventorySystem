using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class AttackItem : Item                                                         // It will also have what Item will have. (Inherited)
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
           

        }
        public int Weight
        {

            get
            {
                return _weight;
            }
        }
        public AttackItem(string newName, int _itemDamage, int _weaponWeight)
        {
            _name = newName;
            _damage = _itemDamage;
            _weight = _weaponWeight;


        }


    }

}
