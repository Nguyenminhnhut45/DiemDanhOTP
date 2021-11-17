using DiemDanhOTP.Core.Domain;
using Upico.Core.Repositories;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface ICourseRepository: IRepository<Course>
    {
        public Task<List<Course>> SearchAll();
        public Task<Course> SearchCourseById(string id);
        public Task<Course> SearchCourseByName(string name);
        public Task<Course> UpdateCourse(string id, Course course);
        public Task<Course> AddCourse(Course course);
        public Task<Course> DeleteCourse(string id);
    }
}
