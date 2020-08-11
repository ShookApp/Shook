using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ShookModel.Models
{

    /// <summary>
    /// Is sent by the ShookREST api and holds information that are needed to use the app
    /// and the REST api.
    /// </summary>
    public class LoginPackage
    {
        /// <summary>
        /// Indicates whether the username and password are right.
        /// </summary>
        [BsonElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// This is the user which logged into ShookApp.
        /// </summary>
        [BsonElement("accountUser")]
        public User AccountUser { get; set; }

        /// <summary>
        /// The API key which is valid for 24 hours. 
        /// </summary>
        [BsonElement("apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// The DateTime until we need a new API Key from the server.
        /// </summary>
        [BsonElement("validUntil")]
        public DateTime ValidUntil { get; set; }
    }
}
