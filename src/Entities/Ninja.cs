using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType): base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = level * 8;
            this.MP = level * 8;
        }

        public override string attack ()
        {
           return this.name + " " +  "Atacou com a suas adagas!";
        }
        
    }
}