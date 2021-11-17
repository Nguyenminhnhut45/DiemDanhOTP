namespace DiemDanhOTP.Core.Domain
{
    public class Session
    {
        public Session()
        {
            Id = Guid.NewGuid().ToString();
            SessionDetails = new HashSet<SessionDetail>();
        }

        public string Id { get; set; }
        public string? Classroom { get; set; }
        public int? SessionNumber { get; set; }
        public int? PeriodStart { get; set; }
        public int? PeriodEnd { get; set; }
        public string? IdGroup { get; set; }
        public string? Day { get; set; }
        public DateTime? Date { get; set; }

        public virtual GroupSubject? GroupSubject { get; set; }
        public virtual ICollection<SessionDetail> SessionDetails { get; set; }
    }
}
