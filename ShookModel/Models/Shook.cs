using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ShookModel.Models
{

    /// <summary>
    /// The shook class.
    /// </summary>
    public class Shook
    {
        #region Variables 

        /// <summary>
        /// The ObjectId that is coming from the database.
        /// </summary>
        [BsonId]
        private ObjectId Id { get; set; }

        /// <summary>
        /// The title of the shook. It can be a short (one liner) description of the shook.
        /// </summary>
        [BsonElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// The full description of the shook.
        /// </summary>
        [BsonElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// The time when the shook starts. It is not the creation time!
        /// </summary>
        [BsonElement("startTime")]
        private DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the shook.
        /// </summary>
        [BsonElement("endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// A list of <see cref="User"/> which are members of this shook.
        /// </summary>
        [BsonElement("member")]
        private List<User> Member { get; set; }

        /// <summary>
        /// The creator of the shook.
        /// </summary>
        [BsonElement("creator")]
        private User Creator { get; set; }
        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Shook()
        {

        }

        #region Methods

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void End()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
