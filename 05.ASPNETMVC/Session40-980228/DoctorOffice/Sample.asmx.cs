﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DoctorOffice
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Sample : System.Web.Services.WebService
    {

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
