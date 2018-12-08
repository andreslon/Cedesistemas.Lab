using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.App.Services
{
    public interface INetworkService
    {
        Task<bool> IsNetworkAvailable();
    }
}
