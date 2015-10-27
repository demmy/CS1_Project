using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;

namespace ContosoUI.ProductForm
{
    public class ProductPresenter : Presenter, IViewPresenter
    {
        private IProductView _view;
        private ProductModel _model;

        ICategoryRepository _categoryRepository = new DummyDAOForCategory();
        //Product STARTs HERE
        private Product _product = new Product();

        private string _sku = string.Empty;
        private string _title = string.Empty;
        private int _quantity;
        private double _price;
        private Category _category;

        BindingList<Comment> _productComments = new BindingList<Comment>(); 
        //Product ENDs HERE

        //Category STARTs HERE
        BindingList<Category> _categories = new BindingList<Category>();
        BindingList<Comment> _categoryComments = new BindingList<Comment>(); 
        //Category ENDs HERE

        public ProductPresenter(IProductView view, ProductModel model)
        {
            _view = view;
            _model = model;
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        private void InitializeProductAndCategoryFiedls()
        {
            _sku = _product.SKU;
            _title = _product.Title;
            _quantity = _product.Quantity;
            _price = _product.Price;
            _category = _product.Category;
            _productComments = new BindingList<Comment>(_product.Comments.ToList());

            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        public void UseProductWithID(int id)
        {
            _product = _model.Find(id);
            InitializeProductAndCategoryFiedls();
        }

        public string SKU
        {
            get { return _sku; }
            set
            {
                if (value == _sku) return;
                _sku = value;
                NotifyPropertyChanged();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == _title) return;
                _title = value;
                NotifyPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value == _quantity) return;
                _quantity = value;
                NotifyPropertyChanged();
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value.Equals(_price)) return;
                _price = value;
                NotifyPropertyChanged();
            }
        }

        public Category Category
        {
            get { return _category; }
            set
            {
                if (Equals(value, _category)) return;
                _category = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> ProductComments
        {
            get { return _productComments; }
            set
            {
                if (Equals(value, _productComments)) return;
                _productComments = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Category> Categories
        {
            get { return _categories; }
            set
            {
                if (Equals(value, _categories)) return;
                _categories = value;
                NotifyPropertyChanged();
            }
        }

        public BindingList<Comment> CategoryComments
        {
            get { return _categoryComments; }
            set
            {
                if (Equals(value, _categoryComments)) return;
                _categoryComments = value;
                NotifyPropertyChanged();
            }
        }

        public void ShowView(ProductPresenter presenter, int id)
        {
            _view.ShowView(presenter, id);
        }

        public void UseCategoryCommentsByID(int id)
        {
            _categoryComments = new BindingList<Comment>(_categoryRepository.Find(id).Comments.ToList());
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SaveAndNew()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
