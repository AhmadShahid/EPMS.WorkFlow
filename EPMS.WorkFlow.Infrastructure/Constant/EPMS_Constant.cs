﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPMS.WorkFlow.Infrastructure.Constant
{

    public enum RequestSource
    {
        Email = 1,
        Phone = 2,
        Personally = 3
    }

    public enum RequestType
    {
        Email = 1,
        Phone = 2,
        Personally = 3
    }

    public static class EPMS_Constants
    {
        public static Dictionary<long, string> RequestSource = new Dictionary<long, string>() { { 1, "Email" }, { 2, "Phone" }, { 3, "Personally" } };
    }
}