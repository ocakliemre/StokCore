﻿using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
   public interface IMenu
    {

        List<Menu> GetAll();

        void Add(Menu menu);

        void Delete(int Id);

    }
}
