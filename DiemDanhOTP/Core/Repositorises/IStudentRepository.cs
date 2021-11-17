using DiemDanhOTP.Core.Domain;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface IStudentRepository
    {
       
        public Task<Student> GetStudentByid(int id);
        public Task<Student> GetStudentByName(string name);
        public Task<Student> GetStudentByClass(string classs);

        public Task<Student> UpdateStudentById(string id, Student student);
     

    }
}
