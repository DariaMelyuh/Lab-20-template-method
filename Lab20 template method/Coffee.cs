namespace Lab20_template_method
{
    internal class Coffee:DrinkBehavior
    {
        private bool _isAddDish;

        public Coffee(bool isAddDish)
        {
            _isAddDish = isAddDish;
        }

        protected override void Brew()
        {
            Console.WriteLine("Заварили кофе!");
        }

        protected override void AddСomponents()
        {
            Console.WriteLine("Добавили сахар с молоком!");
            
        }
        protected override bool IsAddDish()
        {
            return _isAddDish;
        }
    }
}
