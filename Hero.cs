using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Homework
{
    partial class Hero
    {
        string _heroName;
        int _heroHp;
        int _heroDamage;
        int _heroDefense;

        string HeroName
        {
            get { return _heroName; }
            set { _heroName = value; }
        }
        int HeroHp
        {
            get { return _heroHp; }
            set { _heroHp = value;}
        }
        int HeroDamage
        {
            get { return _heroDamage; }
            set { _heroDamage = value; }
        }
        int HeroDefense
        {
            get { return _heroDefense; }
            set { _heroDefense = value; }
        }

        public Hero()
        {
            HeroName = "Unknown Hero";
            HeroHp = 100;
            HeroDamage = 20;
            HeroDefense = 10;
        }

        public Hero(string name, int hp, int damage, int defense)
        {
            HeroName = name;
            HeroHp = hp;
            HeroDamage = damage;
            HeroDefense = defense;
        }
    }
}
