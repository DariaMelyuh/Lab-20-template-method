namespace Lab20_template_method
{
    internal class Tea : DrinkBehavior
    {
        protected override void Brew()
        {
            Console.WriteLine("Заварили чай!");
        }

        protected override void AddСomponents()
        {
            if (IsAddDish())
            {
                Console.WriteLine("Добавили лимон!");
            }
        }

        protected override bool IsAddDish()
        {
            return true;
        }
    }
}
