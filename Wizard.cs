
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Wizard
    {
        public string name;
        public string favoritespell;
        public int spellSlots;
        public float experience;

        public Wizard(string name, string favoritespell)
        {
            this.name = name;
            this.favoritespell = favoritespell;
            spellSlots = 2;
            experience = 0f;
        }

        public void CastSpell()
        {

            if (spellSlots > 0)
            {
                Console.WriteLine(name + " cast " + favoritespell);
                spellSlots--;
                experience += 0.3f;

            }
            else
            {
                Console.WriteLine(name + "no more spellSLots lefft");
            }

        }

        public void Meditate()
        {
            spellSlots++;
            Console.WriteLine(name + " spellSlots increads to " + spellSlots);

        }
    }
}
