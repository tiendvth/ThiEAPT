using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyDbContext
/// </summary>
public class MyDbContext :DbContext
{
    public MyDbContext() : base("name=MyDbContext")
    {

    }

    public DbSet<Product> Products { get; set; }
}