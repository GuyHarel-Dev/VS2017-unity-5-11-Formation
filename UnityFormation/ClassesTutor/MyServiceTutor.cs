using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityFormation.ClassesTutor
{


    public class MyService : IMyService
    {
        private readonly IMyRepository _repository;

        public MyService(IMyRepository repository)
        {
            _repository = repository;
        }

        public string GetData()
        {
            return _repository.FetchData();
        }
    }

}