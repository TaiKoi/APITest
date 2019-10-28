using APITest.Data;
using APITest.DataDTO;
using System;
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
        
        public List<MyDataDTO> GetMyDatas()
        {
            return this.dContext.MyDatas
                   .Select(md => new MyDataDTO
                    {
                        Title = md.Title,
                        Length = md.Length,
                       IsTrue = md.IsTrue
                    }).ToList();
        }

        public void Create(MyDataDTO myDataDto)
        {
            if (myDataDto.Title.Contains("ford"))
                throw new Exception("No fords allowed!");

            var myData = new MyData
            {
                Title = myDataDto.Title,
                Length = myDataDto.Length,
                IsTrue = myDataDto.IsTrue        
            };

            this.dContext.MyDatas.Add(myData);
            this.dContext.SaveChanges();
        }
    }
}
