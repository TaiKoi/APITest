using APITest.DataDTO;
using System.Collections.Generic;

namespace APITest.Service
{
    public interface ITheService
    {
        List<MyDataDTO> GetMyDatas();
        void Create(MyDataDTO myData);
    }
}
