using System;
using System.Collections.Generic;
public class ProductDetail :IComparable<ProductDetail>
   {
     public int ProductId;
     public int GroupId;
     public string ProductName;
     public string Description;
     public int Rate;
     public int CompareTo(ProductDetail other)
     {
         return this.Rate.CompareTo(other.Rate);
     }
     
      }