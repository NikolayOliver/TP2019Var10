using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1.JsonRepositories;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{
    interface IServiceContract<T> 
        where T : IModel
    {
        List<T> GetData();
        
        void AddElement();

        T FindElementById(string Id);
    }
}
