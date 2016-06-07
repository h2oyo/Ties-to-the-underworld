using UnityEngine;
using UnityEditor;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {

        [MenuItem("BZA/Database/Item System Editor %#w")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(400, 300);
            window.title = "Item System Database";
            window.Show();
        }


        void OnEnable()
        {


        }

        void OnGUI()
        {

            TopTabBar();
            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();
            BottomStatusBar();
        }
    }
}

