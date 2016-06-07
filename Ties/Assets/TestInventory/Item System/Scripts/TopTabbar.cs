using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void TopTabBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            WeaponTab();
            ArmorTab();
            PotionsTab();
            AboutTab();
     
       

            GUILayout.EndHorizontal();
        }


        void WeaponTab()
        {
            GUILayout.Button("Weapons");
        }
        void ArmorTab()
        {
            GUILayout.Button("Armor");
        }
        void PotionsTab()
        {
            GUILayout.Button("Potions");
        }

        void AboutTab()
        {
            GUILayout.Button("About");
        }
    }

}