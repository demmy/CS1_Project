﻿using System.Collections.ObjectModel;
using Domain.Entities.Products;
using Domain.Entities.Users;

namespace Data.StoreData
{
    class PermissionDictionary : KeyedCollection<string, Permission>
    {
        protected override string GetKeyForItem(Permission item)
        {
            return item.Title;
        }
    }
    class RoleDictionary : KeyedCollection<string, Role>
    {
        protected override string GetKeyForItem(Role item)
        {
            return item.Title;
        }
    }
    class CategoryDictionary : KeyedCollection<string, Category>
    {
        protected override string GetKeyForItem(Category item)
        {
            return item.Title;
        }
    }
}
