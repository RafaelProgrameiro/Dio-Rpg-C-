using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = level * 5;
            this.MP = level * 10;
        }
        public override string attack ()
        {
            return this.name + " " + "Lançou uma magia!";
        }
        
    }
}