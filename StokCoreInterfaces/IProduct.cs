﻿using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{

    public interface IProduct
    {

        List<Product> GetAll();

        List<Product> GetAllById(int companyId);

        Product Get(int productId, int companyId);

        void Add(Product product);
        int Delete(int Id, int companyId);
        void Update(Product product);

    }
}
