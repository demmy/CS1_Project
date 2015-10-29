using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities.Users
{
    public class User : ExtendedEntity, ICommentable
    {
        public User(ICollection<Comment> comments)
        {
            Comments = comments;
        }

        public User()
        {

        }
        private byte[] HashedPassword { get; set; }
        public string Login { get; set; }
        /// <summary>
        /// Password Hashing using SHA1, not really good, but better then no hashing at all
        /// </summary>
        public string Password
        {
            get
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                return enc.GetString(HashedPassword);
            }
            set
            {
                var sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                HashedPassword = sha1.ComputeHash(System.Text.Encoding.ASCII.GetBytes(value));
            }
        }
        public Role Role { get; set; }
        public Person Person { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }  
    }
}