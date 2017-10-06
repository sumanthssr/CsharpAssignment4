using System;
using System .Collections.Generic;
using ProductDetailNameSpace;
namespace maincontent
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            

            ProductDetailFillClass ProductDetailFillClassObjectRef= new ProductDetailFillClass();
            List<ProductDetail> ProductDetailClassObjectRef =new List<ProductDetail>();
            ProductDetailClassObjectRef=ProductDetailFillClassObjectRef.ProductDetailFill();
            List<ProductGroup> ProductGroupClassObjectRef= new List<ProductGroup>();
            ProductGroupClassObjectRef=ProductDetailFillClassObjectRef.ProductGroupFill();

            
            
            // Search the Item or know more
    while(true)
    {
            Console.WriteLine("1)Display the products in all groups and Search products");
            Console.WriteLine("2)To sort the product on the basis of rate from  Low to High");
            Console.WriteLine("3)To sort the product on the basis of rate from  High to Low");
            Console.WriteLine("4)To sort the product on the basis of product name");
            Console.WriteLine("5)To delete items in list");
            Console.WriteLine("Please enter your choice here");
            Console.WriteLine("----------------------------------------------------------------");
        try
        {
            int num=int.Parse(Console.ReadLine());
        
            switch(num)
             { 
                case 1 :    
                            int k=100;
                            //Display the available item
                            foreach (ProductGroup item1 in ProductGroupClassObjectRef)
                            {  
                            Console.WriteLine("Items availabe in {0} are :",item1.GroupName);
                            Console.WriteLine("----------------------------------------------");
                                int s=1;
                                foreach (ProductDetail item in ProductDetailClassObjectRef)
                                {   
                                    
                                    if(item.GroupId==k)
                                    {  
                                        Console.WriteLine(s+")"+"{0}",item.ProductName);
                                
                                        s++;
                                        Console.WriteLine();
                                    }
                                    
                                }
                                k=k+100;
                            }
                            break;  

                case 2 :
                            Console.WriteLine("              Sorted Product from Low to High rate        ");
                            Console.WriteLine("----------------------------------------------------------------");
                            ProductDetailClassObjectRef.Sort();
                            foreach (ProductDetail item in ProductDetailClassObjectRef)
                            {
                                Console.WriteLine("{0}--------Rate---------{1} per Kg",item.ProductName,item.Rate);
                            }
                            Console.WriteLine(" ----------------------------------------------");
                            break;
                case 3 :
                            Console.WriteLine("              Sorted Product from High to Low rate         ");
                            Console.WriteLine("----------------------------------------------------------------");
                            ProductDetailClassObjectRef.Sort();
                            ProductDetailClassObjectRef.Reverse();
                            foreach (ProductDetail item in ProductDetailClassObjectRef)
                            {
                                Console.WriteLine("{0}--------Rate---------{1} per Kg",item.ProductName,item.Rate);
                            }
                            Console.WriteLine(" ---------------------------------------------");
                            break;
                case 4 :    
                            Console.WriteLine("      Sorted Product List on the basis of product name       ");
                            Console.WriteLine(" ------------------------------------------------------------");
                            ProductDetailFillClassObjectRef.displaySortedProducts();
                            break;
                            
                case 5 :   
                            Console.WriteLine("1)Deleting products on the basis of serial number");
                            Console.WriteLine("2)Deleting on the basis of product name");
                            Console.WriteLine("Pick your choice");
                            int heroswitch=int.Parse(Console.ReadLine());
                            switch(heroswitch)

                            {
                                case 1 :
                                            
                                            Console.WriteLine("     Pick the product group to delete the products in it     ");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine("  1.Dairy  ");
                                            Console.WriteLine("-------------");
                                            Console.WriteLine("1)Dabur cheese");
                                            Console.WriteLine("2)Britania cheese");
                                            Console.WriteLine("-------------");
                                            Console.WriteLine(" 2.Chocolates ");
                                            Console.WriteLine("--------------");
                                            Console.WriteLine("1)DairyMilk");
                                            Console.WriteLine("2)centerfresh");
                                            Console.WriteLine("-------------");
                                            Console.WriteLine("  3.Sweets  ");
                                            Console.WriteLine("-------------");
                                            Console.WriteLine("1)halwa");
                                            Console.WriteLine("2)laddu");
                                            Console.WriteLine("-------------");
                                            Console.WriteLine("To delete products in Dairy.");
                                            Console.WriteLine("Ex.To delete Dabur cheese or Britania cheese.Enter 1!");
                                            try
                                            {
                                            
                                            int switchitem= int.Parse(Console.ReadLine());
                                            switch(switchitem)
                                            {
                                                
                                                            case 1 : 
                                                                    Console.WriteLine("Enter the serial number of product you want to delete from Dairy:");
                                                                    int number = int.Parse(Console.ReadLine());
                                                                    
                                                                    number= number-1;
                                                                    ProductDetailFillClassObjectRef.ProductDelete(ProductDetailClassObjectRef,number);
                                                                    
                                                                    break;
                                                            case 2 : 
                                                                    Console.WriteLine("Enter the serial number of product you want to delete from Chocolate:");
                                                                    number = int.Parse(Console.ReadLine());
                                                                    
                                                                    number= number-1;
                                                                    number=number+2;
                                                                    
                                                                    ProductDetailFillClassObjectRef.ProductDelete(ProductDetailClassObjectRef,number);
                                                                    
                                                                    break;
                                                            case 3 : 
                                                                    Console.WriteLine("Enter the serial number of product you want to delete from Sweets:");
                                                                    number = int.Parse(Console.ReadLine());

                                                                    number= number-1;
                                                                    number=number+4;
                                                                    ProductDetailFillClassObjectRef.ProductDelete(ProductDetailClassObjectRef,number);
                                                                    break;
                                                                    
                                            }
                                            }
                                            catch(Exception e)
                                            {
                                                Console.WriteLine("Group is already empty"+e.Message);
                                                Console.WriteLine("----------------------");
                                            } 
                                            finally
                                            {        
                                                        Console.WriteLine("List of Products after deletion");
                                                        Console.WriteLine("-------------------------------");
                                                        int j=100;
                                                        
                                                        foreach (ProductGroup item1 in ProductGroupClassObjectRef)
                                                        {  
                                                        Console.WriteLine("Items availabe in {0} are :",item1.GroupName);
                                                        Console.WriteLine("-------------------------------------------");
                                                            int l=1;
                                                            foreach (ProductDetail item in ProductDetailClassObjectRef)
                                                            {   
                                                                if(item.GroupId==j)
                                                                {  
                                                                    Console.WriteLine(l+")"+"{0}",item.ProductName);
                                                                    l++;
                                                                }
                                                            
                                                            }
                                                            j=j+100;
                                                        }  
                                            }
                                            string str3="",str4="";
                                            try
                                            {    
                                            int pole=0;
                                            do{
                                                Console.WriteLine("          Search the product          ");
                                                Console.WriteLine("--------------------------------------");

                                                Console.WriteLine("Enter Product name for more details about product.");
                                                Console.WriteLine("Example: Halwa (Enter) will give details about halwa");
                                                string str=Console.ReadLine();
                                                
                                                foreach (ProductDetail item2 in ProductDetailClassObjectRef)
                                                {   
                                                    if(item2.ProductName==str|| (item2.ProductName[0]==str[0])&& item2.ProductName[1]==str[1]){
                                                    Console.WriteLine("Available items --------{0}",item2.ProductName);
                                                    Console.WriteLine("Descriptioncription--------{0}",item2.Description);
                                                    Console.WriteLine("Rate {0} rupees per kg.",item2.Rate);
                                                    Console.WriteLine("---------------------------------------------------------------");
                                                    pole=1;
                                                    }                
                                                    
                                                }
                                                if(pole==0)
                                                {
                                                    Console.WriteLine("Please enter valid product name");
                                                    Console.WriteLine("---------------------------------------------------------------");
                                                    
                                                }
                                                    Console.WriteLine("If you want to know more about any other product.Enter Yes ");
                                                    Console.WriteLine("Exit Enter No ");
                                                    str3=Console.ReadLine();
                                                    str4=str3.ToUpper();

                                                }
                                                while(str4=="YES");
                                                }
                                                
                                                    
                                                catch (System.Exception)
                                                {
                                                    
                                                Console.WriteLine("System Exception have arised");
                                                
                                                }  
                                            break;
                                     
                        case 2 : 
                                Console.WriteLine("Enter the name you want to delete");
                                string Name = Console.ReadLine();
                                Name=Name.ToLower();
                                List<string> ProductName = new List<string>();
                                foreach(ProductDetail str in ProductDetailClassObjectRef )
                                {
                                   ProductName.Add(str.ProductName);
                                }
                                Console.WriteLine("List of products in all groups");
                                Console.WriteLine("-------------------------------");
                                int p=1;
                                foreach(string str in ProductName )
                                {  
                                   
                                   Console.WriteLine(p+")"+str);
                                   p++;
                                }

                                ProductName.Remove(Name);
                                Console.WriteLine();
                                Console.WriteLine("List of products after deletion");
                                Console.WriteLine("-------------------------------");
                                int q=1;
                                foreach(string str in ProductName )
                                {  
                                   
                                   Console.WriteLine(q+")"+str);
                                   q++;
                                }
                                Console.WriteLine();
                                
                                            try
                                            {    
                                            int pole=0;
                                            do{
                                                Console.WriteLine("          Search the product          ");
                                                Console.WriteLine("--------------------------------------");

                                                Console.WriteLine("Enter Product name for more details about product.");
                                                Console.WriteLine("Example: Halwa (Enter) will give details about halwa");
                                                string str=Console.ReadLine();
                                                
                                                foreach (ProductDetail item2 in ProductDetailClassObjectRef)
                                                {   
                                                    if(item2.ProductName==str|| (item2.ProductName[0]==str[0])&& item2.ProductName[1]==str[1]){
                                                    Console.WriteLine("Available items --------{0}",item2.ProductName);
                                                    Console.WriteLine("Descriptioncription--------{0}",item2.Description);
                                                    Console.WriteLine("Rate {0} rupees per kg.",item2.Rate);
                                                    Console.WriteLine("---------------------------------------------------------------");
                                                    pole=1;
                                                    }                
                                                    
                                                }
                                                if(pole==0)
                                                {
                                                    Console.WriteLine("Please enter valid product name");
                                                    Console.WriteLine("---------------------------------------------------------------");
                                                    
                                                }
                                                    Console.WriteLine("If you want to know more about any other product.Enter Yes ");
                                                    Console.WriteLine("Exit Enter No ");
                                                    str3=Console.ReadLine();
                                                    str4=str3.ToUpper();

                                                }
                                                while(str4=="YES");
                                                }
                                                
                                                    
                                                catch (System.Exception)
                                                {
                                                    
                                                Console.WriteLine("System Exception have arised");
                                                
                                                }  
                                break;
                         }
                        break;
                        default:
                                    Console.WriteLine("Please enter valid choice only!");
                                    break;
                                                
                                            
        }
             
              
        }
        catch(Exception e)
        {
            Console.WriteLine("Please enter valid input only!"+e.Message);
        }
        }

    }
}
}

