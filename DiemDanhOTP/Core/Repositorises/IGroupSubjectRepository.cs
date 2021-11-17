using DiemDanhOTP.Core.Domain;
using Upico.Core.Repositories;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface IGroupSubjectRepository: IRepository<GroupSubject>
    {
        public Task<List<GroupSubject>> GetAll();
        public Task<List<GroupSubject>> GetGroupSubject(string id);
        public Task<List<GroupSubject>> GetGroupSubjectByClass(string id);
        public Task<List<GroupSubject>> GetGroupSubjectBySemester(string seme);
        public Task<List<GroupSubject>> GetGroupSubjectByTeacher(string idTeacher);

    }
}
