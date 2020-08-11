using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Net.Mail;

namespace ShookModel.Models
{
    /// <summary>
    /// The user data of a <see cref="User"/>. 
    /// It holds all non shook related information.
    /// </summary>
    public class UserData
    {
        #region Variables 

        /// <summary>
        /// The username of the user.
        /// </summary>
        [BsonElement("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// The profile picture of the user.
        /// </summary>
        [BsonElement("profilePicture")]
        public Object ProfilePicture { get; set; }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        [BsonElement("emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The password of the user.
        /// </summary>
        [BsonElement("password")]
        public string Password { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Checks if the given string is a valid email address and can be used to
        /// register.
        /// </summary>
        /// <param name="mailAddressString">The given email address string.</param>
        /// <returns>True if the string is a valid email.</returns>
        private bool IsValidMail(string mailAddressString)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mailAddressString);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion
    }
}
