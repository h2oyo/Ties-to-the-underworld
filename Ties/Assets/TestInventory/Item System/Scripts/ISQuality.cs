﻿using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem
{
    //[System.Serializable]
    public class ISQuality : ISSQuality
    {
        [SerializeField]
        string _name;
        [SerializeField]
        Sprite _icon;

      public  ISQuality()
        {
            _name = "Commn";
            _icon = new Sprite();

        }
        public string Name
        {

            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Sprite Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
            }
        }


    }
}
