namespace InterfaceExercises
{
    public interface IDoSomething
    {
        public int Age { get; set; }
        public string Name { get; set; }

        string GetName();
        int GetAge();
        int Multiply(int a, int b);
        void Print();
    }
}