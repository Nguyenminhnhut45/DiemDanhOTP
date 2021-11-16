namespace DiemDanhOTP.Core.Domain
{
    public class SessionDetail
    {
        public SessionDetail()
        {
            Session = new Session();
            Student = new Student();
        }
        public string Id { get; set; }
        public string? IdStuddent { get; set; }
        public string? IdSession { get; set; }
        public string Status { get; set; }
        public DateTime? Time { get; set; }
        public string? Note { get; set; }

        public virtual Session Session { get; set; }
        public virtual Student Student { get; set; }
    }
}
