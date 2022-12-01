namespace DoggieNote.Models
{
    public class Competition
    {
        public int CompetitionId { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }

        // A list of courses related to competitions
        public virtual List<Course>? Courses { get; set; }
    }
}
