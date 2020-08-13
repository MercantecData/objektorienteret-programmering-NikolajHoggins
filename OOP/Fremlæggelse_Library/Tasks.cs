using System;
using System.Threading.Tasks;

namespace Fremlæggelse_Library
{
    public class Tasks
    {
        public static Task<string> get(string endpoint)
        {
            Task<string> task = new Task<string>(() =>
            {
                Task.Delay(0).Wait();
                string resp = EndpointService.get(endpoint);
                return resp;
            });

            task.Start();

            return task;
        }
    }
}