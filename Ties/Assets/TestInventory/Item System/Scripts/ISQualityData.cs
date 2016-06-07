﻿using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace BurgZerArcade.ItemSystem { 

public class ISQualityData : ScriptableObject {
      [SerializeField]
       public  List<ISQuality> db = new List<ISQuality>();


        public void Add(ISQuality item)
        {
            db.Add(item);
            EditorUtility.SetDirty(this);
        }
	
        public void Insert (int index, ISQuality item)
        {
            db.Insert(index, item);
            EditorUtility.SetDirty(this);
        }

        public void Remove(ISQuality item)
        {
            db.Remove(item);
            EditorUtility.SetDirty(this);

        }

        public void Remove(int index)
        {
            db.RemoveAt(index);
            EditorUtility.SetDirty(this);
        }

        public int Count 
        {
            get { return db.Count; }
        }

        public ISQuality Get(int index)
        {
            return db.ElementAt(index);
        }

        public void Replace(int index, ISQuality item)
        {
            db[index] = item;
            EditorUtility.SetDirty(this);
        }

	}

}
