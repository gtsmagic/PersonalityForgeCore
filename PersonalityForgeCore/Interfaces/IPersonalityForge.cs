using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalityForgeCore.Models;

namespace PersonalityForgeCore.Interfaces
{
    public interface IPersonalityForge
    {
        Response Send(string username, string message);
        Task<Response> SendAsync(string username, string message);
    }
}
