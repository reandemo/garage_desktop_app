using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Online.Core.Models;

namespace Store_Online.Core.Interfaces;

public interface ISessionService
{
    LoginSession? CurrentSession { get; }

    bool IsLoggedIn { get; }

    string AccessToken { get; }

    void Login(LoginSession session);

    void Logout();
}
