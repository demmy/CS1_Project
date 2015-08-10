using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.UserForm
{
    class UserPresenter
    {
        private readonly IUserView view;

        public UserPresenter(IUserView view)
        {
            this.view = view;
        }

        public void GetUser(int id)
        {
            Data.DummyData.DummyDAOForUser DefaultUser = new Data.DummyData.DummyDAOForUser();
            var CurrentUser = DefaultUser.Find(id);

            view.Login = CurrentUser.Login;
            view.Password = CurrentUser.Password;
            view.FirstName = CurrentUser.Person.FirstName;
            view.MiddleName = CurrentUser.Person.MiddleName;
            view.LastName = CurrentUser.Person.LastName;
            view.Role = CurrentUser.Role.Title;
            view.Active = CurrentUser.IsActive;
            //view.Comments = (ICollection<Domain.Entities.Comments.Comment>)CurrentUser.Comments;
        }
    }
}
