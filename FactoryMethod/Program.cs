namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laboratory laboratory = new HealPotionLaboratory("Vita");
            laboratory.Cook();
            laboratory = new DamagePotionLaboratory("Boomq");
            laboratory.Cook();
        }
    }
}
