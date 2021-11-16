namespace DiemDanhOTP.Core.Domain
{
    public class Session
    {
        public Session()
        {
            SessionDetails = new HashSet<SessionDetail>();
        }

        public int Id { get; set; }
        public string? Classroom { get; set; }
        public int? SessionNumber { get; set; }
        public int? PeriodStart { get; set; }
        public int? PeriodEnd { get; set; }
        public string? IdGroup { get; set; }
        public string? Day { get; set; }
        public DateTime? Date { get; set; }

        public virtual GroupSubject? IdgroupNavigation { get; set; }
        public virtual ICollection<SessionDetail> SessionDetails { get; set; }
    }
}
