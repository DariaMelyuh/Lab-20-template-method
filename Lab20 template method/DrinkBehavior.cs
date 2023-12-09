namespace Lab20_template_method
{
    internal abstract class DrinkBehavior
    {
        public void Make()
        {
            BoilerWater();
            PourIntoMug();
            Brew();
            AddСomponents();
        }

        public void BoilerWater()
        {
            Console.WriteLine("\nВскипятили воду!");
        }

        public void PourIntoMug()
        {
            Console.WriteLine("Налили воду в кружку!");
        }

        protected abstract void Brew();
        protected abstract void AddСomponents();
        protected abstract bool IsAddDish();
    }
}
