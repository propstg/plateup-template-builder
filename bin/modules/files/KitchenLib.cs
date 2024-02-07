using KitchenLib;
using KitchenMods;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace KitchenMyMod {

    public class Mod : BaseMod, IModSystem {

        public const string MOD_GUID = "com.example.mymod";
        public const string MOD_NAME = "My Mod";
        public const string MOD_AUTHOR = "My Name";
        public const string MOD_GAMEVERSION = ">=1.1.8";
        public static readonly string MOD_VERSION = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion.ToString();

        public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly()) { }

        protected override void OnInitialise() {
            Log($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate() {
        }

        protected override void OnPostActivate(KitchenMods.Mod mod) {
        }

        [Conditional("DEBUG")]
        public static void DebugLog(object message, [CallerFilePath] string callingFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
            Log(message, callingFilePath, lineNumber, caller);
        }

        public static void Log(object message, [CallerFilePath] string callingFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
            UnityEngine.Debug.Log($"[{MOD_GUID}] [{caller}({callingFilePath}:{lineNumber})] {message}");
        }
    }
}
