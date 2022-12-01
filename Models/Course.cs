namespace DoggieNote.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }


        // Relation to Competition
        public int CompetitionId { get; set; }
        public virtual Competition Competition { get; set; }
    }
}
