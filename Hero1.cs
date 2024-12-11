using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Homework
{
    partial class Hero
    {
        public void TakeDamage(int damage)
        {
            Console.WriteLine($"몬스터가 플레이어 {HeroName} 에게 {damage - HeroDefense} 만큼의 피해를 입혔습니다 ");
            HeroHp -= (damage - HeroDefense);
        }
        public void AttackMob(Monster monster)
        {
            Console.WriteLine($"플레이어 {_heroName} 가 몬스터를 공격했습니다. ");
            monster.TakeDamage(_heroDamage);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"현재 플레이어의 이름은 {HeroName} 입니다.");
            Console.WriteLine($"현재 플레이어의 체력은 {HeroHp} 입니다.");
            Console.WriteLine($"현재 플레이어의 공격력은 {HeroDamage} 입니다.");
            Console.WriteLine($"현재 플레이어의 방어력은 {HeroDefense} 입니다.");
            Console.WriteLine("------------------------------------");
        }
        
        public bool HeroAlive(Hero hero)
        {
            if(hero.HeroHp < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int PlayerDie(Hero hero)
        {
            if (hero.HeroHp <= 0)
            {
                return 0;
            }
            else
            {
                return hero.HeroHp;
            }
        }
    }
}
