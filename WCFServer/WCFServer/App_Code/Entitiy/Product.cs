using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>

[DataContract]
public class Product
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public double price { get; set; }

    [DataMember]
    public int Status { get; set; }
    public Product()
    {
        
        //
        // TODO: Add constructor logic here
        //
    }
}