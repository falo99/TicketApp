using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Models;
using Xamarin.Essentials;

namespace TicketApp.Services
{
    public static class Database
    {
        public static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if(db != null)
            {
                return;
            }
         
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyDataBase1.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<User>();


        }
        static async Task create(string name, string surname, string email, string login, string password)
        {
            await Init();
            var User = new User
            {
                Name = name,
                Surname = surname,
                Email = email,
                Login = login,
                Password = password
            };

            var id = await db.InsertAsync(User);
        }
        public static async Task<IEnumerable<User>> GetUser()
        {
            await Init();
            var user = await db.Table<User>().ToListAsync();
            return user;
        }
    }
}
