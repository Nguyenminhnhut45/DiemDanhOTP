using DiemDanhOTP.Core.Domain;
using Upico.Core.Repositories;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface IStudentRepository: IRepository<Student>
    {
       
        public Task<Student> GetStudentByid(int id);
        public Task<Student> GetStudentByName(string name);
        public Task<Student> GetStudentByClass(string classs);

        public Task<Student> UpdateStudentById(string id, Student student);
     

    }
}
