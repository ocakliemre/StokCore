﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
  public interface IEmail
    {

        void SendMail(string Email,string CompanyName);
            
        
    }
}
