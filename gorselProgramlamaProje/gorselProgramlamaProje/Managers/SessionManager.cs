using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Managers
{
    public static class SessionManager
    {
        /// Giriş yapan kullanıcının Id’si.
        public static int CurrentUserId { get; set; }

        /// İstersen kullanıcı adı, rol, token gibi başka bilgileri de buraya ekleyebilirsin.
        public static string? CurrentUsername { get; set; }
    }
}
