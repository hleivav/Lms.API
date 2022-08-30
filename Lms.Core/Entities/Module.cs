namespace Lms.Core.Entities
{
    public class Module
    {
        public int Id { get; set; }
        string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public int MyProperty { get; set; }
    }
}