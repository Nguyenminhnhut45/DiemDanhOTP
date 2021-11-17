namespace DiemDanhOTP.Core.Domain
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid().ToString();
            SessionDetails = new HashSet<SessionDetail>();
            Studies = new HashSet<Study>();
        }

        public string Id { get; set; } = null!;
      
        public string? Class { get; set; }
        public string? IdUser { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<SessionDetail> SessionDetails { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
    }
}
