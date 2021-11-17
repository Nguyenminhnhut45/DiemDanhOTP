namespace DiemDanhOTP.Core.Domain
{
    public class Teacher
    {
        public Teacher()
        {
            Id = Guid.NewGuid().ToString();
            GroupSubjects = new HashSet<GroupSubject>();
        }

        public string Id { get; set; }
        public string? IdUser { get; set; }

        public User? User { get; set; }
        public virtual ICollection<GroupSubject> GroupSubjects { get; set; }
    }
}
