using GoGreenApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GoGreenApp.Data
{
    interface IRestService <T>
    {
        Task<List<T>> getAll();
    }
}
