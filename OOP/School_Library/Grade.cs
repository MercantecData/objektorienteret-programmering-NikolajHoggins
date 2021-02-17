namespace School_Library
{
    public class Grade
    {
        private string subject;
        private int grade;
        private string note;

        public Grade(string subject, int grade, string note)
        {
            this.subject = subject;
            this.grade = grade;
            this.note = note;
        }

        public int GetGrade()
        {
            return this.grade;
        }

        public string GetNote()
        {
            return this.note;
        }

        public string GetSubject()
        {
            return this.subject;
        }

        public void ChangeGrade(int grade)
        {
            this.grade = grade;
        }

        public void ChangeGrade(string note)
        {
            this.note = note;
        }
    }
}