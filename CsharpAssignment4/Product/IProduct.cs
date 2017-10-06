using System;
using System.Collections.Generic;
using ProductDetailNameSpace;
namespace ProdutInterface
{
    public interface IProduct
    {
        List<ProductGroup> ProductGroupFill();

        List<ProductDetail> ProductDetailFill();

        IEnumerable<ProductDetail> ProductSort(List<ProductDetail> pinfo);

        List<ProductDetail> ProductDelete(List<ProductDetail> pinfo, int number);
    }
}