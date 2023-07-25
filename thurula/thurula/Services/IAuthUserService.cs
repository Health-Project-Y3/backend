﻿using thurula.Models;

namespace thurula.Services;

public interface IAuthUserService
{
    string GetMyName();
    
    List<User> Get();
    User Create(User user);
    void Remove(User userIn);
    User Get(string id);
    void Update(string id, User user);
}