using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        Vector2 _scrollPos = Vector2.zero;
        int _listViewWidth = 200;
        void ListView()
        {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(200));
            GUILayout.Label("List View");
            GUILayout.EndScrollView();
        }
    }
}
