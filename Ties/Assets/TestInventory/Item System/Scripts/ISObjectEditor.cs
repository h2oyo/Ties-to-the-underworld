using UnityEngine;
using UnityEditor;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        ISWeaponDataBase database;
 
        const string DATABASE_FILE_NAME = @"bzaWeaponDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_FILE_NAME;

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
                if (database == null)
                    database = ISWeaponDataBase.GetDatabase<ISWeaponDataBase>(DATABASE_PATH, DATABASE_FILE_NAME);
       
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

