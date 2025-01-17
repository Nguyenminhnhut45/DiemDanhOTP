﻿using DiemDanhOTP.Core.Domain;
using Upico.Core.Repositories;

namespace DiemDanhOTP.Core.Repositorises
{
    public interface ISessionRepository: IRepository<Session>
    {
        public Task<List<Session>> GetAll();
        public Task<Session> GetSessionById(string idSesion);
        public Task<Session> SearchUserByClassroom(string classRoom);
        public Task<Session> GetSessionByDate(DateTime dateTime);
        
    }
}
