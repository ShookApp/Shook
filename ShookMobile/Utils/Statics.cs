using ShookModel.Models;

namespace ShookMobile.Utils
{
    /// <summary>
    /// This class holds some static variables which are used during runtime.
    /// </summary>
    static class Statics
    {
        /// <summary>
        /// The valid <see cref="LoginPackage"/> which is coming from
        /// the <see cref="LoginManager"/>.
        /// </summary>
        public static LoginPackage LoginPackage;

        /// <summary>
        /// The API key for ShookREST which is coming from
        /// the <see cref="LoginManager"/>.
        /// </summary>
        public static string ApiKey;

        /// <summary>
        /// The URL of the Shook server that runs the REST api.
        /// </summary>
        public const string ShookServer = "https://raspberrypi:5000/";

        /// <summary>
        /// Method to delete the static variables for example when the user wants to logout.
        /// </summary>
        public static void DeleteAllStatics()
        {
            LoginPackage = new EmptyLoginPackage();
            ApiKey = "";
        }
    }
}