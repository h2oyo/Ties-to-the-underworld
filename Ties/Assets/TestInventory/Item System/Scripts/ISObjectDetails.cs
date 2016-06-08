using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
      public  ISWeapon tempWeapon = new ISWeapon();
        bool ShowNewWeaponDetails = false;
        void ItemDetails()
        {
            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));


            if (ShowNewWeaponDetails)
                DisplayNewWeapon();

       
            GUILayout.EndVertical();

            GUILayout.Space(50);
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            DisplayButtons();
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();

        }
        void DisplayNewWeapon()
        {
            ISWeapon tempWeapon = new ISWeapon();
            tempWeapon.OnGUI();

        
            
        }

        void DisplayButtons()
        {
            if (!ShowNewWeaponDetails)
            {
                if (GUILayout.Button("Create Weapon"))
                {
                    tempWeapon = new ISWeapon();
                    ShowNewWeaponDetails = true;

                }
            }
            else
            {
                if (GUILayout.Button("Save"))
                {
                    ShowNewWeaponDetails = false;
                    tempWeapon = null;
                }
                if (GUILayout.Button("Cancel"))
                {
                    ShowNewWeaponDetails = false;
                    tempWeapon = null;
                }
            }
          }
      }
  }