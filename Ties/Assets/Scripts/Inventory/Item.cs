﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
    private string _name;
    private int _value;
    private RarityTypes _rarity;
    private int _curDur;
    private int _maxDur;

    public Item()
    {
        _name = "Need Name";
        _value = 0;
        _rarity = RarityTypes.Common;
        _maxDur = 50;
        _curDur = _maxDur;
    }

    public Item(string name, int value, RarityTypes rare, int maxDur, int curDur)
    {
        _name = name;
        _value = value;
        _rarity = rare;
        _maxDur = maxDur;
        _curDur = curDur;
    }

public string Name
{
    get { return _name; }
        set { _name = value; }
}
    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public RarityTypes Rarity
    {
        get { return _rarity; }
        set { _rarity = value; }
    }
     public int MaxDurablilty
    {
        get { return _maxDur; }
        set { _maxDur = value; }
    }
    public int CurDurablilty
    {
        get { return _curDur; }
        set { _curDur = value; }
    }


    public enum RarityTypes
    {
        Common,
        Uncommon,
        Rare
    }
}

