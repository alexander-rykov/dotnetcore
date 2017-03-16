namespace GcGenerations
{
    public class First
    {
    }

    public class Second
    {
        public First First { get; set; }
    }

    public class Third
    {
        public First First { get; set; }

        public Second Second { get; set; }
    }
}
