using APITest.Data;
using System.Collections.Generic;
using System.Linq;

namespace APITest.Service
{
    public class TheService : ITheService
    {
        private DContext dContext;

        public TheService()
        {
        }

        public TheService(DContext dContext)
        {
            this.dContext = dContext;
        }
        public List<MyData> GetMyDatas()
        {
            return this.dContext.MyDatas.ToList();
        }
    }
}
