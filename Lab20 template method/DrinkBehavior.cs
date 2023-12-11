namespace Lab20_template_method
{
    internal abstract class DrinkBehavior
    {
        public void Make()
        {
            BoilerWater();
            PourIntoMug();
            Brew();
            if (IsAddDish())
            {
                AddСomponents();
            }
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

        protected virtual bool IsAddDish()
        {
            return true;
        }
    }
}
