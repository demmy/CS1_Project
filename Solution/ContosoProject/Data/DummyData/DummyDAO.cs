using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities;
using Domain.Entities.Products;
using Domain.Entities.Users;

namespace Data.DummyData
{
    class DummyDAO<T> : IRepository<T> where T : Entity, new()
    {
        protected WeakReference AdminPermissionsCollection = new WeakReference(Storage.AdminPermissions);
        protected WeakReference CategoriesCollection = new WeakReference(Storage.Categories);
        protected WeakReference ClientTelephonesCollection = new WeakReference(Storage.ClientTelephones);
        protected WeakReference ClientsCollection = new WeakReference(Storage.Clients);
        protected WeakReference DirectorPermissionsCollection = new WeakReference(Storage.DirectorPermissions);
        protected WeakReference GodCommentsCollection = new WeakReference(Storage.GodComments);
        protected WeakReference LocationsCollection = new WeakReference(Storage.Locations);
        protected WeakReference ManagerPermissionsCollection = new WeakReference(Storage.ManagerPermissions);
        protected WeakReference OrderItemsCollection = new WeakReference(Storage.OrderItems);
        protected WeakReference OrdersCollection = new WeakReference(Storage.Orders);
        protected WeakReference PermissionsCollection = new WeakReference(Storage.Permissions);
        protected WeakReference ProductsCollection = new WeakReference(Storage.Products);
        protected WeakReference RolesCollection = new WeakReference(Storage.Roles);
        protected WeakReference UsersCollection = new WeakReference(Storage.Users);

        protected WeakReference PermissionDictionary = new WeakReference(new PermissionDictionary());
        protected WeakReference RoleDictionary = new WeakReference(new RoleDictionary());
        protected WeakReference CategoryDictionary = new WeakReference(new CategoryDictionary());


        protected IList<T> _collection = new List<T>(); 
        public void Create(T entity)
        {
            if(!(_collection.Any(x => x == entity)))
            _collection.Add(new T());
        }

        public T Find(int id)
        {
            if (!(_collection.Any(x => x.Id == id)))
            {
                return _collection.First(x => x.Id == id);
            }
            throw new Exception();
        }

        public ICollection<T> GetAll()
        {
            return _collection;
        }

        public ICollection<T> GetByIsActive(bool isActive)
        {
            return (ICollection<T>) _collection.Select(x => x.IsActive == isActive).ToList();
        }

        public void Save(T entity)
        {
            T oldEntity = _collection.First(x => x.Id == entity.Id);
            oldEntity.Id = entity.Id;
            oldEntity.IsActive = entity.IsActive;
        }

        public void Delete(T entity)
        {
            if (!(_collection.Any(x => x == entity)))
            {
                _collection.Remove(entity);
            }
            throw new Exception();

        }

        public void Delete(int id)
        {
            if (!(_collection.Any(x => x.Id == id)))
            {
                _collection.RemoveAt(id);
            }
            throw new Exception();
        }
    }
}
