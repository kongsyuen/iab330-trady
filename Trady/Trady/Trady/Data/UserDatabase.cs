using Trady.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Trady.Data
{
    public class UserDatabase
    {
        readonly SQLiteAsyncConnection database;
        public UserDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
            database.CreateTableAsync<Inquiries>().Wait();

        }

        // Get specific user
        public Task<User> GetUserAsync(string userName, string password)
        {
            return database.Table<User>()
                            .Where(i => i.UserName == userName && i.Password == password)
                            .FirstOrDefaultAsync();
        }

        //Username collision detection
        public Task<User> UsernameCollision(string userName)
        {
            return database.Table<User>()
                            .Where(i => i.UserName == userName)
                            .FirstOrDefaultAsync();
        }

        public Task<Inquiries> GetInquiryAsync(string InquiryName)
        {
            return database.Table<Inquiries>()
                            .Where(i => i.InquiryName == InquiryName)
                            .FirstOrDefaultAsync();
        }

        //Add user to the database
        public Task<int> SaveUserAsync(User user)
        {
            if (user.ID != 0)
            {
                return database.UpdateAsync(user);
            }
            else
            {
                return database.InsertAsync(user);
            }
        }

        // Delete user (not used in this solution)
        public Task<int> DeleteUserAsync(User user)
        {
            return database.DeleteAsync(user);
        }

        //Insert Inquiry
        public Task<int> SaveInquiryAsync(Inquiries inquiry)
        {
            if (inquiry.InquiryID != 0)
            {
                return database.UpdateAsync(inquiry);
            }
            else
            {
                return database.InsertAsync(inquiry);
            }
        }

    }
}
