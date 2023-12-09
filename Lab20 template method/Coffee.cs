﻿namespace Lab20_template_method
{
    internal class Coffee:DrinkBehavior
    {
        private bool _additives;

        public Coffee(bool additives)
        {
            _additives = additives;
        }

        protected override void Brew()
        {
            Console.WriteLine("Заварили кофе!");
        }

        protected override void AddСomponents()
        {
            if (IsAddDish())
            {
                Console.WriteLine("Добавили сахар с молоком!");
            }
            else
            {
                Console.WriteLine("Без Добавок!");
            }
        }
        protected override bool IsAddDish()
        {
            return _additives;
        }
    }
}
