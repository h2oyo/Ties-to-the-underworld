using UnityEngine;
using UnityEditor;
using System.Collections;
namespace BurgZerArcade.ItemSystem
{
    [System.Serializable]
    public class ISObject : IISObject
    {
        [SerializeField]
        Sprite _icon;
        [SerializeField]
        string _name;
        [SerializeField]
        int _value;
        [SerializeField]
        int _burden;
        [SerializeField]
        ISQuality _quality;

        public string ISName { get { return _name; } set { _name = value; } }
        public int ISValue { get { return _value; } set { _value = value; } }
        public Sprite ISIcon { get { return _icon; } set { _icon = value; } }

        public int ISBurden { get { return _burden; } set { _burden = value; } }

        public ISQuality Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        public virtual void OnGUI()
        {
            GUILayout.BeginVertical();
            _name = EditorGUILayout.TextField("Name", _name);
            _value = System.Convert.ToInt32(EditorGUILayout.TextField("Value", _value.ToString()));
            _burden = System.Convert.ToInt32(EditorGUILayout.TextField("Burden", _burden.ToString()));
            DispalyIcon();
            DispalyQuality();
            GUILayout.EndVertical();
        }


        public void DispalyIcon()
        {
            GUILayout.Label("Icon");
        }
        ISQualityData qdb;
        int qualitySelectedIndex = 0;
        string[] options;
        public ISObject()
        {
            string DATABASE_FILE_NAME = @"bzaQualityDatabase.asset";
            string DATABASE_PATH = @"Database";
            qdb = ISQualityData.GetDatabase<ISQualityData>(DATABASE_PATH, DATABASE_FILE_NAME);
            options = new string[qdb.Count];
            for(int cnt = 0; cnt < qdb.Count; cnt++)
             options[cnt] = qdb.Get(cnt).Name;
            
        }


       
        public void DispalyQuality()
        {

            qualitySelectedIndex = EditorGUILayout.Popup("Quality", qualitySelectedIndex, options);
        }

    }
}
