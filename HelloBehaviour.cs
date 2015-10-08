using UnityEngine;

namespace HelloMod
{
    class HelloBehaviour : MonoBehaviour
    {
        void OnGUI()
        {
            GUIStyle style = new GUIStyle();

            style.fontSize = 100;

            GUI.Label(new Rect(50, 50, 400, 200), "Hello mods!", style);
        }
    }
}
