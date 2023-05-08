using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleGame.Data.Entities.Player_Entities;

namespace consoleGame.Data.Entities.Player_Entities
{

    public class Weapons : InGameItems
    {
        public int AttackPower { get; set; }
        public int Accuracy { get; set; }
    }

}

        // public Weapons(int id, int AP, int ACC, string name)
        // {
        //     AttackPower = AP;
        //     Accuracy = ACC;
        //     Name = name;
        //     ID = id;
        // }