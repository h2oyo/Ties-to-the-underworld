using UnityEditor;
using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{ 
public class ISQualityDatabaseEditor : EditorWindow {
        ISQualityData db;
        ISQuality selectedItem;
        Texture2D selectedTexture;

        const int SPRITE_BUTTON_SIZE = 92;

        const string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
        const string DATABASE_FOLDER_NAME = @"Database";
        const string DATABASE_PATH = @"Assets/"+ DATABASE_FOLDER_NAME +"/" + DATABASE_FILE_NAME;

        [MenuItem("BZA/Database/Quality Editor %#i")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.title = "Quality Database";
            window.Show();
        }

        void OnEnable()
        {
            db = AssetDatabase.LoadAssetAtPath(DATABASE_PATH, typeof(ISQualityData)) as ISQualityData;
            if (db == null)
            {
                if (!AssetDatabase.IsValidFolder("Assets/" +DATABASE_FOLDER_NAME))
                {
                    AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);
                    
                }
                db = ScriptableObject.CreateInstance<ISQualityData>();
                AssetDatabase.CreateAsset(db, DATABASE_PATH);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            selectedItem = new ISQuality();
        }

        void OnGUI()
        {
            AddQualityToDatabase();
        }

        void AddQualityToDatabase()
        {
            selectedItem.Name = EditorGUILayout.TextField("Name:", selectedItem.Name);
            if(selectedItem.Icon)
            
                selectedTexture = selectedItem.Icon.texture;

                GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE));
           

        }
	
	}
}
