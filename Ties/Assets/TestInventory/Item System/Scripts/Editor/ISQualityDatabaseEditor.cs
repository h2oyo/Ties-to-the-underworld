using UnityEditor;
using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{ 
public partial class ISQualityDatabaseEditor : EditorWindow {
        ISQualityData qualityDatabase;
        ISQuality selectedItem;
        Texture2D selectedTexture;
        int selectedIndex = -1;
        Vector2 _scrollPos;

        const int SPRITE_BUTTON_SIZE = 46;

        const string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
        const string DATABASE_PATH = @"Database";
       const string DATABASE_FULL_PATH = @"Assets/"+ DATABASE_PATH +"/" + DATABASE_FILE_NAME;

        [MenuItem("BZA/Database/Quality Editor %#w")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.title = "Quality Database";
            window.Show();
        }

        void OnEnable()
        {
      if(qualityDatabase == null)
            qualityDatabase = ISQualityData.GetDatabase<ISQualityData>(DATABASE_PATH, DATABASE_FILE_NAME);
        }

        void OnGUI()
        {
            if (qualityDatabase == null)
            {
                Debug.LogWarning("qualityDatabase not loaded");
                return;
            }
           ListView();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
           
            
        }
        void BottomBar()
        {
            GUILayout.Label("Qualities :" + qualityDatabase.Count);

            if(GUILayout.Button("Add"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }

    
        }
	
	}

