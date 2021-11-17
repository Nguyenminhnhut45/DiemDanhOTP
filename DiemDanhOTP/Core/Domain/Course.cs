namespace DiemDanhOTP.Core.Domain
{
    public class Course
    {
        public Course ()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string  Id { get; set; }
        public string? Name { get; set; }
        public int NOC { get; set; }
        public int Period { get; set; }


    }
}
