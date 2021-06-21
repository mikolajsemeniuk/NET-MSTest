using System;
using System.Threading.Tasks;

namespace Logic
{
    public class BussinessLogic
    {
        public int Calculate(int x, int y) => x + y;
        public void MyMethodWithError() => throw new Exception("something gone wrong");
        public Task<string> MyMethodWithErrorAsync(bool x)
        {
            if (x) 
                throw new Exception("something went wrong");
            return Task.FromResult<string>("hej");
        }
    }
}