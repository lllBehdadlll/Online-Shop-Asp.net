﻿using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategory;

namespace ShopManagement.Application.Contracts.Product
{
    public interface IProductApplication
    {
        OperationResult Create(CreateProduct command);
        OperationResult Edit(EditProduct command);
        EditProduct GetDetails(long id);
        List<ProductViewModel> Search(ProductSearchModel searchmodel);
        List<ProductViewModel> GetProducts();
    }
}
 