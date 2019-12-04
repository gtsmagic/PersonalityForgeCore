using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalityForge.Models;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using PersonalityForgeCore.Models;

namespace PersonalityForgeCore.Interfaces
{
    internal interface IPersonalityForgeDataService
    {
        Response Send(ApiInfo apiInfo, string username, string text);
        Task<Response> SendAsync(ApiInfo apiInfo, string username, string text);
    }
}
