using System.Security.Claims;

namespace JwtWebApi.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _context;

        public UserService(IHttpContextAccessor context)
        {
            _context = context;
        }
        public string GetMyName()
        {
            var result = string.Empty;
            if (_context.HttpContext != null)
                result = _context.HttpContext.User.FindFirstValue(ClaimTypes.Name);

            return result;
        }
    }
}
