using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Testing_Ado.Net
{
    internal class ProductDal
    {
        private readonly SqlConnection _connection =
            new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Metin2;integrated security=true");

        public void ConnectionOpenControlled()
        {
            if (_connection.State == ConnectionState.Closed) _connection.Open();
        }

        public List<Product> GetAll()
        {
            ConnectionOpenControlled();
            var command = new SqlCommand("Select * from Products", _connection);
            var reader = command.ExecuteReader();
            var products = new List<Product>();
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        public void Add(Product product)
        {
            ConnectionOpenControlled();
            var command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionOpenControlled();
            var command =
                new SqlCommand(
                    "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id",
                    _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionOpenControlled();
            var command = new SqlCommand("Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}