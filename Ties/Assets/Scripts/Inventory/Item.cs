﻿using UnityEngine;
using System.Collections;

public class Item {
    private string _name;
    private int _value;
    private RarityTypes _rarity;
    private int _curDur;
    private int _maxDur;
    private Texture2D _icon;


    private int _maxDamage;
    private float _dmgVar;

    public Item()
    {
        _name = "Need Name";
        _value = 0;
        _rarity = RarityTypes.Common;
        _maxDur = 50;
        _curDur = _maxDur;
        _maxDamage = 0;
        _dmgVar = 0;
    }

    public Item(string name, int value, RarityTypes rare, int maxDur, int curDur, int nDmg, float dmgV)
    {
        _name = name;
        _value = value;
        _rarity = rare;
        _maxDur = maxDur;
        _curDur = curDur;
        _maxDamage = nDmg;
        _dmgVar = dmgV;
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
    public int MaxDamage
    {
        get { return _maxDamage; }
        set { _maxDamage = value; }
    }

    public float DamageVariance
    {
        get { return _dmgVar; }
        set { _dmgVar = value; }
    }
    public Texture2D Icon
    {
            get { return _icon; }
          set { _icon = value; }

    }
    public virtual string ToolTip()
    {
        return Name + "\n" +
            "Value:" + Value + "\n" +
            "Durability:" + CurDurablilty + "/" + MaxDurablilty + "\n";
    }
    public enum RarityTypes
    {
        Common,
        Uncommon,
        Rare
    }
}
