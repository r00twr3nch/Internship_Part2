using Dapper;
using DapperExample;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class UserRepository
{
    private readonly string _connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=Internship2db;Trusted_Connection=True;";

    public IEnumerable<User> GetAllUsers()
    {
       var db = new SqlConnection(_connectionString);
        return db.Query<User>("SELECT * FROM emailTable");
    }

    public void AddUser(User user)
    {
        var db = new SqlConnection(_connectionString);
        db.Execute("INSERT INTO emailTable (Name, Email) VALUES (@Name, @Email)", user);
    }
}
