using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO.src.Entities
{
    public abstract class Hero
    {

        public string name;
        public int level;
        public string heroType;
        public int HP;
        public int MP;
       
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            
        }

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.heroType;
        }

        public virtual string attack()
        {
            return this.name + "Atacou!";
        }

        public string superAttack(int bonus)
        {
            if(bonus >= 4)
            {
                return this.name + " " + "Lançou um ataque critico";
            }
            else 
            {
                return this.name + " " + "Lançou um ataque com bônus";
            }
            
        }

       public void status()
       {

            System.Console.WriteLine($"Name: {name}");        
            System.Console.WriteLine($"Level: {level}");          
            System.Console.WriteLine($"Class: {heroType}");    
            System.Console.WriteLine($"HP: {HP}");           
            System.Console.WriteLine($"MP: {MP}");
            System.Console.WriteLine();
         }
     
    }
}