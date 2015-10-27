using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ProductForm
{
    public interface IProductView
    {
        void ShowView(ProductPresenter presenter, int id);
    }
}