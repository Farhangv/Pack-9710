namespace MVCDemo.Models
{
    public class Course
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public override string ToString()
        {
            return $"{Title}({Duration} Hours)";
        }
    }
}