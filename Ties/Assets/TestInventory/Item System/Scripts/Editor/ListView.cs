using UnityEngine;
using UnityEditor;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {

        void ListView()
        {
           _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));

            DisplayQualities();

            EditorGUILayout.EndScrollView();
        }
      
        void DisplayQualities()
        {

            for(int cnt= 0; cnt < datab.Count; cnt++)
            {
                GUILayout.BeginHorizontal();
                if (datab.Get(cnt).Icon)
                    selectedTexture = datab.Get(cnt).Icon.texture;
                else
                    selectedTexture = null;

                if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
                {
                    int controlerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                    EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controlerID);
                    selectedIndex = cnt;
                }

                string commandName = Event.current.commandName;
                if (commandName == "ObjectSelectorUpdated")
                {
                    if (selectedIndex != -1)
                    {

                        datab.Get(selectedIndex).Icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                        selectedIndex = -1;

                     
                    }
                    Repaint();
                }

                datab.Get(cnt).Name = GUILayout.TextField(datab.Get(cnt).Name);

                if(GUILayout.Button("x"))
                {
                    if(EditorUtility.DisplayDialog("Delete Quality", "Are you sure that you want to delete" + datab.Get(cnt).Name + "from the database", "Delete", "Cancel"))

                    {
                        datab.Remove(cnt);
                    }
                    GUILayout.EndHorizontal();
                }
            }

        }
    }
}
