using GARAJ.Debugging;

namespace GARAJ
{
    public class GARAJConsts
    {
        public const string LocalizationSourceName = "GARAJ";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "46418489ad534c79a557c9834fe4a08a";
    }
}
