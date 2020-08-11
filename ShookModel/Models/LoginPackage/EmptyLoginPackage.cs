using System;
namespace ShookModel.Models
{

    /// <summary>
    /// A class which is derived from <see cref="LoginPackage"/>. 
    /// An EmptyLoginPackage is sent by the api if the login was NOT successful.
    /// </summary>
    public class EmptyLoginPackage : LoginPackage
    {

        /// <summary>
        /// All properties are set in the constructor.
        /// </summary>
        public EmptyLoginPackage()
        {
            this.Success = false;
            this.AccountUser = null;
            this.ApiKey = "";
            this.ValidUntil = DateTime.MinValue;
        }
    }
}
