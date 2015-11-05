using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Comments;

namespace Domain.Entities.Users
{
    /// <summary>
    /// The static class the enables hashing operations on strings
    /// </summary>
    public static class Hashing
    {
        /// <summary>
        /// Hashes the entry string
        /// </summary>
        /// <param name="unhashed">The string not empty instance</param>
        /// <returns>Hashed string</returns>
        public static string CreateHash(this string unhashed)
        {
            if (string.IsNullOrWhiteSpace(unhashed))
                throw new ArgumentException("Entry string is null, empty or contains only white spaces. You need to specify it.");
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            return System.Text.Encoding.ASCII.GetString(md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(unhashed)));
        }
    }

    public class User : ExtendedEntity, ICommentable
    {
        private string _hashedPassword;
        public User(ICollection<Comment> comments)
        {
            Comments = comments;
        }

        public User()
        {

        }

        public string Login { get; set; }
        /// <summary>
        /// Password Hashed using MD5
        /// </summary>
        public string Password
        {
            get
            {
                return _hashedPassword;
            }
            set
            {
                _hashedPassword = value.CreateHash();
            }
        }
        /// <summary>
        /// The position of user of this application
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// General info of each registered person
        /// </summary>
        public Person Person { get; set; }
        /// <summary>
        /// The comments applied to current user
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }  

        public override string ToString()
        {
            return string.Format("{0}", Login);
        }
    }
}