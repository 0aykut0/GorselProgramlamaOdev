﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Managers
{
    public static class SessionManager
    {
        public static int CurrentUserId { get; set; }

        public static string? CurrentUsername { get; set; }
    }
}
