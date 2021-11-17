using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Repositorises;
using Upico.Persistence.Repositories;

namespace DiemDanhOTP.Persistence.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly DiemDanhDBContext _context;
        public StudentRepository(DiemDanhDBContext context):base(context)
        {
            this._context = context;
        }
      


        public async Task<Student> GetStudentByClass(string classs)
        {
            var students = await _context.Students.FindAsync(classs);
            if(students == null)
            {
                ///khogn bt tra ve gi
            }
            return students;
        }

        public async Task<Student> GetStudentByid(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return null;
            }

            return student;
        }

        public async Task<Student> GetStudentByName(string name)
        {
            var student = await _context.Students.FindAsync(name);

            if (student == null)
            {
                return null;
            }

            return student;
        }

        public async Task<Student> UpdateStudentById(string id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
