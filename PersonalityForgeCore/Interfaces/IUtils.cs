﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityForgeCore.Interfaces
{
    interface IUtils
    {
        string GenerateSecret(string secret, string data);
        int GenerateTimestamp();
        string FilterJson(byte[] response);
    }
}
