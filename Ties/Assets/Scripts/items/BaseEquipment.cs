using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseItem {

    public enum EquipmentTypes
    {
        Head,
        Chest,
        Shoulders,
        Legs,
        Feet,
        Neck,
        Earring,
        Ring
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;
    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }
    public int SpellEfecctID
    {
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }
}
