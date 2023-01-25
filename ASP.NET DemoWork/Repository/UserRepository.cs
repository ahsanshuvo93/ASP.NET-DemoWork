using ASP.NET_DemoWork.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ASP.NET_DemoWork.Repository
{
    public class UserRepository : BaseRepository
    {

        public async Task<IEnumerable<User>> GetAllUser()
        {
            try
            {
                var query = "select * from [dbo].[User]";

                var con = GetDbConnection();
                con.Open();
                var response = await con.QueryAsync<User>(query);
                con.Close();

                return response.AsEnumerable();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public async Task<User> GetUserById(Guid userId)
        {
            try
            {
                var query = "select * from [dbo].[User] where UserId = @userId";

                var con = GetDbConnection();
                con.Open();
                var response = await con.QueryFirstOrDefaultAsync<User>(query, new { userId } );
                con.Close();

                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> AddUser(User model)
        {
            try
            {
                var query = "insert into [dbo].[User] values (@userId, @name, @email, @phone, @password, @birthdate, @image, @status)";

                var parameters = new DynamicParameters();

                parameters.Add("userId", Guid.NewGuid(), DbType.Guid);
                parameters.Add("name", model.FullName, DbType.String);
                parameters.Add("email", model.Email, DbType.String);
                parameters.Add("phone", model.PhoneNumber, DbType.String);
                parameters.Add("password", model.Password, DbType.String);
                parameters.Add("birthdate", model.Birthdate, DbType.DateTime);
                parameters.Add("image", model.Image, DbType.String);
                parameters.Add("status", model.Status, DbType.String);

                var con = GetDbConnection();
                con.Open();
                var response = await con.ExecuteAsync(query, parameters);
                con.Close();

                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //public Guid UpdateUser(User model)
        //{
        //    Guid result = new Guid();
        //    if (model != null)
        //    {
        //        //_context.Entry(model).State = EntityState.Modified;
        //        _context.SaveChanges();
        //        result = model.UserId;
        //    }
        //    return result;
        //}
        //public void DeleteUser(Guid id)
        //{
        //    User model = _context.Users.Find(id);
        //    _context.Users.Remove(model);
        //    _context.SaveChanges();

        //}

        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}