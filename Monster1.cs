using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Homework
{
    partial class Monster
    {
        public void TakeDamage(int damage)
        {
            Console.WriteLine($"플레이어가 {_mobName} 에게 {damage - MobDefense} 만큼의 피해를 입혔습니다 ");
            MobHp -= (damage - MobDefense);
        }
        public void AttackHero(Hero hero)
        {
            Console.WriteLine($"몬스터 {MobName} 이 플레이어를 공격했습니다. ");
            hero.TakeDamage(MobDamage);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"현재 몬스터의 이름은 {MobName} 입니다.");
            Console.WriteLine($"현재 몬스터의 체력은 {MobHp} 입니다.");
            Console.WriteLine($"현재 몬스터의 공격력은 {MobDamage} 입니다.");
            Console.WriteLine($"현재 몬스터의 방어력은 {MobDefense} 입니다.");
            Console.WriteLine($"현재 몬스터의 레벨은 {MobLevel} 입니다.");
            Console.WriteLine("------------------------------------");
        }

        public bool MonsterAlive(Monster monster)
        {
            if (monster.MobHp < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int MonsterDie(Monster monster)
        {
            if (monster.MobHp <= 0)
            {
                return 0;
            }
            else
            {
                return monster.MobHp;
            }
        }
    }
}
