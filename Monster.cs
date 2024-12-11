using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Homework
{
    partial class Monster
    {
        string _mobName;
        int _mobHp;
        int _mobDamage;
        int _mobDefense;
        int _mobLevel;

        string MobName
        {
            get { return _mobName; }
            set { _mobName = value; }
        }
        int MobHp
        {
            get { return _mobHp; }
            set { _mobHp = value; }
        }
        int MobDamage
        {
            get { return _mobDamage; }
            set { _mobDamage = value; }
        }
        int MobDefense
        {
            get { return _mobDefense; }
            set { _mobDefense = value; }
        }
        int MobLevel
        {
            get { return _mobLevel; }
            set { _mobLevel = value; }
        }

        public Monster()
        {
            MobName = "Basic Monster";
            MobHp = 50;
            MobDamage = 15;
            MobDefense = 5;
            MobLevel = 1;
        }

        public Monster(string name, int hp, int damage, int defense, int level)
        {
            MobName = name;
            MobHp = hp;
            MobDamage = damage;
            MobDefense = defense;
            MobLevel = level;
        }
    }
}
