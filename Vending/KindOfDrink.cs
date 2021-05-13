﻿namespace Vending
{
    public sealed class KindOfDrink
    {
        public static readonly KindOfDrink COKE = new KindOfDrink(0);
        public static readonly KindOfDrink DIET_COKE = new KindOfDrink(1);
        public static readonly KindOfDrink TEA = new KindOfDrink(2);

        private readonly int kind;

        private KindOfDrink(int kind)
        {
            this.kind = kind;
        }

        public bool Is(KindOfDrink kindOfDrink)
        {
            return kind == kindOfDrink.kind;
        }
    }
}