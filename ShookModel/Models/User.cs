using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ShookModel.Models
{

    /// <summary>
    /// The user class.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class User
    {
        #region Variables

        /// <summary>
        /// The ObjectId of the user which is coming from the database. 
        /// </summary>
        [BsonId]
        [BsonElement("id")]
        public ObjectId Id { get; set; }

        /// <summary>
        /// The <see cref="UserData"/> of the user.
        /// </summary>
        [BsonElement("userData")]
        public UserData UserData { get; set; }

        /// <summary>
        /// All shooks the user ever took part in. 
        /// </summary>
        [BsonElement("shooks")]
        public List<Shook> Shooks { get; set; }

        /// <summary>
        /// The amount of created shooks.
        /// </summary>
        [BsonElement("createdShooks")]
        public int CreatedShooks { get; private set; }

        /// <summary>
        /// The amount of the won shooks of this user.
        /// </summary>
        [BsonElement("wonShooks")]
        public int WonShooks { get; private set; }

        #endregion

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public User()
        {
            // TODO: Add method for calculating the CreatedShooks and WonShooks
            // when a User instance is created.
            CreatedShooks = 0;
            WonShooks = 0;
        }

        #region Methods 

        public void CreateShook()
        {
            throw new NotImplementedException();
        }

        public void EditShook(Shook shook)
        {
            throw new NotImplementedException();
        }

        public void JoinShook(Shook shook)
        {
            throw new NotImplementedException();
        }

        public void LeaveShook(Shook shook)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
