namespace InterfaceExercises
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        void DeleteName(string name);
    }
}