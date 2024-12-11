using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Homework
{
    internal class Game
    {
        Hero Arhcer;
        Monster Skeleton;

        public Game()
        {
            Arhcer = new Hero("Archer", 100, 30, 5);
            Skeleton = new Monster("Skeleton", 50, 20, 5, 1);
        }

        public void Play()
        {
            Console.WriteLine("게임이 시작되었습니다");
            while(Arhcer.HeroAlive(Arhcer) && Skeleton.MonsterAlive(Skeleton))
            {
                Console.WriteLine("다음 행동 중 무엇을 하시겠습니까?");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. 영웅이 몬스터를 공격");
                Console.WriteLine("2. 몬스터가 영웅을 공격");
                Console.WriteLine("3. 현재 영웅 상태창을 확인");
                Console.WriteLine("4. 현재 몬스터 상태창을 확인");
                Console.WriteLine("------------------------------");
                ConsoleKeyInfo inputKey = Console.ReadKey();

                if(inputKey.Key == ConsoleKey.D1 || inputKey.Key == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    Arhcer.AttackMob(Skeleton);
                }
                else if (inputKey.Key == ConsoleKey.D2 || inputKey.Key == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    Skeleton.AttackHero(Arhcer);
                }
                else if (inputKey.Key == ConsoleKey.D3 || inputKey.Key == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    Arhcer.DisplayInfo();
                }
                else if (inputKey.Key == ConsoleKey.D4 || inputKey.Key == ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    Skeleton.DisplayInfo();
                }
                if (Arhcer.PlayerDie(Arhcer) == 0)
                {
                    Console.WriteLine("영웅 사망으로 종료");
                    break;
                }
                if(Skeleton.MonsterDie(Skeleton) == 0)
                {
                    Console.WriteLine("몹 사망으로 종료");
                    break;
                }
            }
        }
    }
}
