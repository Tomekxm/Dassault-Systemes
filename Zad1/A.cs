namespace Zad1
{
    class A
    {
        private int _c;
        private int _d;

        public int C { get => _c; private set => _c = value; }
        public int D { get => _d; private set => _d = value; }

        public A(int c, int d)
        {
            C = c;
            D = d;
        }

        public virtual string Test() => $"{C},{D}";
    }
}
