using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Core.Repositorises;

namespace DiemDanhOTP.Persistence.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DiemDanhDBContext _context;
        public CourseRepository(DiemDanhDBContext context)
        {
            _context = context;
        }
        public Task<Course> AddCourse(Course course)
        {
            throw new NotImplementedException();
        }
        //Delete course
        public async Task<Course> DeleteCourse(string id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
               // return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return null;

        }

        public async Task<List<Course>> SearchAll()
        {
            throw new NotImplementedException();
           /* var avatars = await _context.Courses.ToListAsync();

            return avatars;*/
        }
        //Get by id
        public async Task<Course> SearchCourseById(string id)
        {
             var course = await _context.Courses.FindAsync(id);

            if (course == null)
            {
                throw new NotImplementedException();
            }

            return course;
        }
        //Get by name
        public async Task<Course> SearchCourseByName(string name)
        {
           var course= await _context.Courses.FindAsync(name);
            if (course == null)
            {
                return null;
            }
            return course;
        }
        //update cource 
        public Task<Course> UpdateCourse(string id, Course course)
        {
            throw new NotImplementedException();
        }
    }
}
