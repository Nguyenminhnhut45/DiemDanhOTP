using DiemDanhOTP.Core.Domain;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface IGroupSubjectRepository
    {
        public Task<List<GroupSubject>> GetAll();
        public Task<List<GroupSubject>> GetGroupSubject(string id);
        public Task<List<GroupSubject>> GetGroupSubjectByClass(string id);
        public Task<List<GroupSubject>> GetGroupSubjectBySemester(string seme);
        public Task<List<GroupSubject>> GetGroupSubjectByTeacher(string idTeacher);

    }
}
