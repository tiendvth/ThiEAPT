using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private MyDbContext db = null;
    

    public static List<Product> listProduct = new List<Product>();
    public  Product Save(Product product)
    {
        db = new MyDbContext();
        listProduct.Add(product);
        return product;
        throw new NotImplementedException();
    }

    public List<Product> GetList()
    {
        return listProduct;
        throw new NotImplementedException();
    }
}
