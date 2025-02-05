using UnityEditor;
using UnityEditor.Compilation;

namespace CodeBase.Editor
{
    public static class ForceScriptsRecompile
    {
        [MenuItem("Tools/Force Recompile Scripts %#r")] // Ctrl + Shift + R (Cmd + Shift + R на Mac)
        public static void Recompile()
        {
            CompilationPipeline.RequestScriptCompilation();
            UnityEngine.Debug.Log("🔄 Перекомпиляция скриптов запущена!");
        }
    }
}