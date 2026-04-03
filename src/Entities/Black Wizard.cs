using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogodeRPG.src.Entities
{
    public class BlackWizard: Hero
    {
        
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public  override string Attack()
        {
            return this.Name + " " + "Lançou sua magia negra";
        }
    }
}