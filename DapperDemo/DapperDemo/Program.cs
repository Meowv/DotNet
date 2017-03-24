using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=True");


            //string sql = "Insert into Users values (@UserName, @Email, @Address)";


            //var result = conn.Execute(sql, new
            //{ UserName = "qix", Email = "123@meowv.com", Address = "上海" });



            //var usersList = Enumerable.Range(0, 10).Select(i => new Users()
            //{
            //    Email = i + "meowv.com",
            //    Address = "湖北",
            //    UserName = i + "qix"
            //});

            //var result = conn.Execute(sql, usersList);



            //string sql = "select * from Users where UserName=@UserName";
            //var query = conn.Query<Users>(sql, new { UserName = "qix" });



            //string sql = "UPDATE Users SET UserName='wushaung' WHERE UserID=@UserID";
            //var result = conn.Execute(sql, new { UserID = 11 });


            //string sql = "delete from Users where UserID=@UsersID";
            //var result = conn.Execute(sql, new { UsersID = 11 });


            //var sql = "select * from Users where Email in @emails";
            //var info = conn.Query<Users>(sql, new { emails = new string[2] { "1meowv.com", "2meowv.com" } });


            //var sql = "select * from Product; select * from Users";
            //var multiReader = conn.QueryMultiple(sql);
            //var productList = multiReader.Read<Product>();
            //var userList = multiReader.Read<Users>();
            //multiReader.Dispose();



            //var sql = @"select  p.ProductName,p.CreateTime,u.UserName
            //            from Product as p
            //            join Users as u
            //            on p.UserID = u.UserID
            //            where p.CreateTime > '2015-12-12'";
            //var result = conn.Query<Product, Users, Product>(sql, (product, users) =>
            //   {
            //       product.UserOwner = users;
            //       return product;
            //   }, splitOn: "UserName");
            //var result2 = conn.Query(sql);



            var info = conn.Query<Users>("sp_GetUsers", new { id = 5 },
                commandType: CommandType.StoredProcedure);
        }
    }
}
