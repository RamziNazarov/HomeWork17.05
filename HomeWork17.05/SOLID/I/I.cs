using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17._05.SOLID.I
{
    abstract class People : IPeople
    {
        public void Defend()
        {
            Console.WriteLine("I defend");
        }

        public void Walk()
        {
            Console.WriteLine("I walk");
        }
    }
    class Wizard :People,IWizard
    {

        public void CastSpell()
        {
            Console.WriteLine("Cast spell");
        }
    }
    class SwordMan : People,ISwordMan
    {
        public void SwordAtack()
        {
            Console.WriteLine("Sword atack");
        }
    }
    class Archer : People, IArcher
    {
        public void ArrowAtack()
        {
            Console.WriteLine("Arrow atack");
        }
    }
    interface IPeople
    {
        void Defend();
        void Walk();
    }
    interface IArcher
    {
        void ArrowAtack();
    }
    interface IWizard
    {
        void CastSpell();
    }
    interface ISwordMan
    {
        void SwordAtack();
    }
}
