using System;
using Xunit;
using ProductDetailNameSpace;
using ProdutInterface;
using System.Collections.Generic;
namespace test.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ProductDetail objProductDetail1=new ProductDetail();
            ProductDetail objProductDetail2=new ProductDetail();
            ProductDetail objProductDetail3=new ProductDetail();
            ProductDetailFillClass objProductDetailFill=new ProductDetailFillClass();
            List<ProductDetail> listProductDetail=new List<ProductDetail>(3);
            List<ProductDetail> listProductDetailAfterDelete=new List<ProductDetail>();
            listProductDetail.Add(objProductDetail1);
            listProductDetail.Add(objProductDetail2);
            listProductDetail.Add(objProductDetail3);
            //Act
            int intCountlistProductDetail=listProductDetail.Count;
            listProductDetailAfterDelete=objProductDetailFill.ProductDelete(listProductDetail,1);
            int intCountlistProductDetailAfterDelete=listProductDetailAfterDelete.Count;
            //Assert
            Assert.IsType<int>(intCountlistProductDetail);
            Assert.IsType<int>(intCountlistProductDetailAfterDelete);
            Assert.Equal(intCountlistProductDetailAfterDelete+1,intCountlistProductDetail);
            Assert.NotEqual(intCountlistProductDetailAfterDelete,intCountlistProductDetail);
        }
    }
}
