using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityFormation.ClassesTutor
{
    public class MyRepository : IMyRepository
    {
        public string FetchData()
        {
            return "Données depuis MyRepository";
        }
    }
}