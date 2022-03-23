namespace Zad1
{
    class B : A
    {
        private int _e;

        public B() : base(2, 3)
        {
            E = 1;
        }

        public int E { get => _e; private set => _e = value; }

        public override string Test() => $"{E},{base.Test()}";

    }
}

