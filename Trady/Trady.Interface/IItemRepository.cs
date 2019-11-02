using System;
using Trady.Models;

namespace Trady.Interface
{
    public interface IItemRepository : IRepository<Item>
    {
        Item Get(int id);
    }
}
