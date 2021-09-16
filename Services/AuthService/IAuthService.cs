using JAP_Task_1_MoviesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services.AuthService
{
    public interface IAuthService
    {
        string CreateToken(User user);
    }
}
