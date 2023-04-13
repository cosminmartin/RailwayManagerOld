﻿using DataAccess.Contracts.Contracts.User;

namespace DataAccess.Contracts.Repositories.Users
{
    public interface IUserReadRepository
    {
        Task<User> GetUserAsync(GetUserByIdContract contract);
    }
}
