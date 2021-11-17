namespace DiemDanhOTP.Core.Domain
{
    public class Study
    {
        public Study ()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string? IdGroupSubject { get; set; }
        public string? IdStudent { get; set; } = null!;



        public byte? Stt { get; set; }

        public virtual GroupSubject GroupSubject { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
