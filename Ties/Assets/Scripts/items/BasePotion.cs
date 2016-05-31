using UnityEngine;
using System.Collections;

public class BasePotion : BaseItem {

	public enum PotionTypes
    {
        Health,
        Mana,
        Strength,
        Intellect,
        vit,
        dex
    }
    private PotionTypes potionType;
    private int spellEffectID;
    public PotionTypes PotionType
    {
        get { return potionType; }
        set { potionType = value; }
    }
    public int SpellEfecctID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
