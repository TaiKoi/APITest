using APITest.Data;
using System.Collections.Generic;

namespace APITest.Service
{
    public interface ITheService
    {
        List<MyData> GetMyDatas();
    }
}
