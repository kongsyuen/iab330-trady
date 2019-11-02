using System;
using System.Collections.Generic;
using System.Diagnostics;
using SQLite;
using Trady.Interface;
using Trady.Models;

namespace Trady.SQLiteRepository
{
    public class ItemRepository : IItemRepository
    {
        SQLiteConnection sqlite;
        public ItemRepository(string databasePath)
        {
            Debug.WriteLine("databasePath : {0}", databasePath);
            sqlite = new SQLiteConnection(databasePath);

            InitTable();

        }

        private void InitTable()
        {
            string sqlcmd = "SELECT Count(*) FROM sqlite_master WHERE type='table' AND name=?";
            var result = this.sqlite.ExecuteScalar<int>(sqlcmd, "Item");
            if (result == 0)
            {
                this.sqlite.CreateTable<Item>();
            }
        }

        public void Delete(Item entity)
        {
            this.sqlite.Delete<Item>(entity.ID);
        }

        public void DeleteAll()
        {
            this.sqlite.DeleteAll<Item>();
        }

        public void Dispose()
        {
            this.sqlite.Dispose();
        }

        public Item Get(int actorId)
        {
            return this.sqlite.Get<Item>(actorId);
        }

        public IList<Item> GetAll()
        {
            return this.sqlite.Query<Item>("SELECT * FROM Item");
        }

        public void Insert(Item entity)
        {
            this.sqlite.Insert(entity);
        }

        public void InsertAll(IList<Item> entities)
        {
            this.sqlite.InsertAll(entities);
        }

        public void Update(Item entity)
        {
            this.sqlite.Update(entity);
        }

        public void UpdateAll(IList<Item> entities)
        {
            this.sqlite.UpdateAll(entities);
        }

        public ItemRepository()
        {
        }

        
    }
}
