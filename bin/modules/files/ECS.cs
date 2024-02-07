using Kitchen;
using KitchenMods;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KitchenMyMod {

    public class Mod : GameSystemBase, IModSystem {

        public const string MOD_GUID = "com.example.mymod";
        public const string MOD_NAME = "My Mod";
        public const string MOD_AUTHOR = "My Name";
        public static readonly string MOD_VERSION = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion.ToString();

        protected override void Initialise() {
            Log($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate() {
        }
            
        [Conditional("DEBUG")]
        public static void DebugLog(object message, [CallerFilePath] string callingFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
            Log(message, callingFilePath, lineNumber, caller);
        }

        public static void Log(object message, [CallerFilePath] string callingFilePath = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null) {
            UnityEngine.Debug.Log($"[{MOD_ID}] [{caller}({callingFilePath}:{lineNumber})] {message}");
        }
    }
}
