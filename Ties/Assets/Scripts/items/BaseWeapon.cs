using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseItem { //BaseWeapon <- BaseStatItem <- BaseItem

	public enum WeaponTypes
    {
        Sword,
        Staff,
        Sheild
    }

    public WeaponTypes weaponType;
    private int spellEffectID;
    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }
    public int SpellEffectID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
