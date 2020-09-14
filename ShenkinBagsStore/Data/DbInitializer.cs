
using ShenkinBagsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    public class DbInitializer
    {
          public static void Initialize(MVCShenkinBagsStoreContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any())
            {
                return; // DB is full already
            }
            var products = new Product[]
            {
                new Product{Price=59,ProductName="NailonBag",ProductTypeId=3,Description="blabla",Quantity=7,Metrial="plastic"},
                new Product{Price=86,ProductName="Aliminuim Bag",ProductTypeId=4,Description="blabla",Quantity=100,Metrial="plastic"}, 
                new Product{Price=104,ProductName="Classic Bag",ProductTypeId=5,Description="blabla",Quantity=78,Metrial="plastic"}

            };
            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();
            var users = new User[]
            {
                new User{UserName="Elior Dayari",Password="123456",Email="EliorDayari@gmail.com",Phone="0509712120"},
              new User{UserName="Yarin Meron",Password="7891011",Email="Yarinmeron1@gmail.com",Phone="0523980505"},
                new User{UserName="Zeevi Gev",Password="12131415",Email="Zeevigev@gmail.com",Phone="0502050270"}

            };
            foreach (User c in users)
            {
                context.Users.Add(c);
            }
            context.SaveChanges();

            var transactions = new Transaction[]
           {
                new Transaction{TransactionDate=DateTime.Parse("1959-4-15"),UserID=1,ProductID=1},
                 new Transaction{TransactionDate=DateTime.Parse("1960-4-15"),UserID=2,ProductID=2},
                  new Transaction{TransactionDate=DateTime.Parse("1938-4-15"),UserID=3,ProductID=3},


           };
            foreach (Transaction t in transactions)
            {
                context.Transactions.Add(t);
            }
            context.SaveChanges();


        }
    }

