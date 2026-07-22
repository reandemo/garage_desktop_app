using Store_Online.Core.Interfaces;
using Store_Online.Core.Models;

namespace Store_Online.Core.Services
{
    public class SessionService : ISessionService
    {
        private LoginSession? _currentSession;

        public LoginSession? CurrentSession => _currentSession;

        public bool IsLoggedIn
            => _currentSession?.IsLoggedIn == true;

        public string AccessToken
            => _currentSession?.AccessToken ?? string.Empty;

        public void Login(LoginSession session)
        {
            if (session == null)
                throw new ArgumentNullException(nameof(session));

            if (string.IsNullOrWhiteSpace(session.AccessToken))
                throw new ArgumentException("Access token is required.");

            session.IsLoggedIn = true;
            session.LoginTime = DateTime.UtcNow;

            _currentSession = session;
        }

        public void Logout()
        {
            _currentSession = null;
        }
    }
}
