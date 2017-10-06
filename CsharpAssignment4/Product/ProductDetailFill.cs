using System;
using System.Collections.Generic;
using ProdutInterface;
using System.Linq;
namespace ProductDetailNameSpace
{
   
  //end of PGroup
    public class ProductDetailFillClass: IProduct,IComparer<ProductDetail> 
       {
          
          public List<ProductGroup> ProductGroupFill()
          {
              ProductGroup ProductGroupref1=new ProductGroup()
              {
              GroupId=100,
              GroupName="Diary"
              };
              ProductGroup ProductGroupref2 =new ProductGroup()
              {
              GroupId=200,
              GroupName="Chocolates"
              };
              ProductGroup ProductGroupref3 =new ProductGroup()
              {
              GroupId=300,
              GroupName="Sweets"
              };
        
              List<ProductGroup> ProductGroupList=new List<ProductGroup>(3);
                ProductGroupList.Add (ProductGroupref1);
                ProductGroupList.Add (ProductGroupref2);
                ProductGroupList.Add(ProductGroupref3);
              return ProductGroupList;
          }
          public List<ProductDetail> ProductDetailFill()
          {    
              ProductDetail ProductDetailref1 =new ProductDetail()
              {   
                  GroupId=100,
                  ProductId=101,
                  ProductName="Dabur cheese",
                  Description="150 gm dabur cheese",
                  Rate=200

              };
                ProductDetail ProductDetailref2 =new ProductDetail()
              {  GroupId=100,
                  ProductId=102,
                  ProductName="Britania cheese ",
                  Description="150 gm britania cheese",
                  Rate=220

              };
                    
                ProductDetail ProductDetailref3 =new ProductDetail()
              {  
                  
                  GroupId=200,
                  ProductId=201,
                  ProductName="DairyMilk",
                  Description="10 gm DairyMilk",
                  Rate=600
              };
                ProductDetail ProductDetailref4 =new ProductDetail()
              {  
                  
                  GroupId=200,
                  ProductId=202,
                  ProductName="centrefresh ",
                  Description="150 gm centre fresh",
                  Rate=520
              };
                ProductDetail ProductDetailref5 =new ProductDetail()
              {  
                  GroupId=300,
                  ProductId=301,
                  ProductName="halwa ",
                  Description="150 gm halwa",
                  Rate=300
              };
                ProductDetail ProductDetailref6 =new ProductDetail()
              {  
                  GroupId=300,
                  ProductId=302,
                  ProductName="laddu",
                  Description="150 gm amul cheese",
                  Rate=350
              };
        
              List<ProductDetail> productList=new List<ProductDetail>(6);
                productList.Add (ProductDetailref1);
                productList.Add (ProductDetailref2);
                  productList.Add (ProductDetailref3);
                  productList.Add (ProductDetailref4);
                    productList.Add (ProductDetailref5);
                    productList.Add (ProductDetailref6);    
                    return productList;
          }
          public List<ProductDetail> ProductDelete(List<ProductDetail> pinfo, int number)
            {
            pinfo.RemoveAt(number);
            return pinfo;
            }
          public int Compare(ProductDetail objProductInfoA,ProductDetail objProductInfoB)
          {
            return objProductInfoA.ProductName.CompareTo(objProductInfoB.ProductName);
           }
          public IEnumerable<ProductDetail> ProductSort(List<ProductDetail> listProductDetail)
          {
            ProductDetailFillClass listProductDetailsFill=new ProductDetailFillClass();
            listProductDetail.Sort(listProductDetailsFill);
            return listProductDetail;
           }
        public void displaySortedProducts()
        {
            try
            {
                ProductDetailFillClass objProductDetailsFill = new ProductDetailFillClass();

                List<ProductGroup> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<ProductDetail> listProductDetail = objProductDetailsFill.ProductDetailFill();
                IEnumerable<ProductDetail> listProductDetailEnumerable = objProductDetailsFill.ProductSort(listProductDetail);

                foreach (ProductGroup item1 in listProductGroup)
                {
                    foreach (ProductDetail item2 in listProductDetailEnumerable)
                    {
                        if(item1.GroupId == item2.GroupId)
                        {
                            int intIndex=listProductDetail.IndexOf(item2);
                            Console.WriteLine("Index:"+intIndex +"|| Product Group Name: "+item1.GroupName+" || Product Name: "+item2.ProductName+" ||Product Description: "+item2.Description+" ||Product Rate: "+item2.Rate);
                            intIndex++;
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        
       }

}
