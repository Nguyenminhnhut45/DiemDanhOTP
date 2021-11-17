namespace DiemDanhOTP.Core.Domain
{
    public  class GroupSubject
    {
        public GroupSubject()
        {
            Id = Guid.NewGuid().ToString();
            Sessions = new HashSet<Session>();
            Studies = new HashSet<Study>();
        }

        public string Id { get; set; }
        public string? IdCourse { get; set; }
        public string IdTeacher { get; set; }
        public string? Class { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public byte? Semester { get; set; }
        public int? Year { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
    }
}
