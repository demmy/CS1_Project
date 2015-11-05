using Domain.DAO;
using Domain.Entities.Comments;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.CategoryForm
{
    public class CategoryPresenter : Presenter
    {
        ICategoryView _view;
        CategoryModel _model;
        ICategoryRepository _categoryRepository;

        private String _searchTitleCategory = string.Empty;
        BindingList<Category> _categories = new BindingList<Category>();
        private Category _categoryToSave = null;
        BindingList<Comment> _categoryComments = new BindingList<Comment>();
        private Category _categoryInUse = new Category();
        private int _id;
        private bool _state;

        public CategoryPresenter(ICategoryView view, CategoryModel model)
        {
            _view = view;
            _model = model;
            _categoryRepository = model.CategoryRepository;
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        private void InitializeAllTheFields()
        {
            InitializeCategoryFields();
            _categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
        }

        private void InitializeCategoryFields()
        {
            _categoryComments = new BindingList<Comment>( _categoryInUse.Comments.ToList());
        }

        public void UseCategoryWithID(int id)
        {
            _categoryInUse = _categoryRepository.Find(id);
            _categoryComments = new BindingList<Comment>(_categoryInUse.Comments.ToList());
        }

        private void SaveCategory()
        {
            SaveCategoryInUse();
            if (_categoryRepository.GetAll().Count() < _categories.Count)
            {
                _categoryRepository.Create(_categoryToSave);
            }
            if (!_categoryRepository.GetAll().SequenceEqual(_categories))
            {
                foreach (var category in _categories)
                {
                    _categoryRepository.Save(category);
                }
            }
        }

        public void SaveCategoryInUse()
        {
            Category categoryToSave = new Category(_categoryComments) 
            { 
                Date = _categoryInUse.Date, 
                Id = _categoryInUse.Id, 
                IsActive = _categoryInUse.IsActive, 
                Title = _categoryInUse.Title
            };
            _categories[_categories.IndexOf(_categories.First(x => x.Title == categoryToSave.Title))] = categoryToSave;
        }

        public void Save()
        {
            SaveCategory();
        }        

        public void SaveAndNew()
        {
            Save();
            New();
        }

        public void New()
        {
            
        }

        public void AddCategoryWithTitle(string title)
        {
            _categories.Add(_categoryToSave  = new Category() { Title = title });
        }

        public void Search()
        {
            Categories = new BindingList<Category>(_categoryRepository.FindBy(x => x.Title.ToLower().StartsWith(_searchTitleCategory.ToLower())).ToList());
        }

        public void AllCategoriesToGrid()
        {
            Categories = new BindingList<Category>(_categoryRepository.GetAll().ToList());
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
                if (value.SequenceEqual(_categoryComments)) return;
                _categoryComments = value;
                NotifyPropertyChanged();
            }
        }

        public string SearchTitleCategory
        {
            get { return _searchTitleCategory; }
            set
            {
                if (_searchTitleCategory.Equals(value)) return;
                _searchTitleCategory = value;
                NotifyPropertyChanged();
            }
        }

        public Category CategoryInUse
        {
            get { return _categoryInUse; }
            set { _categoryInUse = value; }
        }

        private int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
