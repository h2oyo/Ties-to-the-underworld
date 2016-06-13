using UnityEngine;


public static class ItemGenenerator  {
    public const int BASE_MELEE_RANGE = 1;

    private const string MELEE_WEAPON_PATH = "Item Icons/Weapon/";
    public static Item CreateItem()
    {

       Item item = CreateMeleeWeapon();
        item.Value = Random.Range(1, 101);
        item.Rarity = Item.RarityTypes.Common;
        item.MaxDurablilty = Random.Range(50, 61);
        item.CurDurablilty = item.MaxDurablilty;
        return item;
    }
    private static Weapon CreateWeapon()
    {
        Weapon weapon = CreateMeleeWeapon();




        return weapon;
    }

    public static Weapon CreateMeleeWeapon()
    {
        Weapon Meleeweapon = new Weapon();
        string[] weaponNames = new string[3];

        weaponNames[0] = "Short Sword";
        weaponNames[1] = "Axe";
        weaponNames[2] = "Sword";

        Meleeweapon.Name = weaponNames[Random.Range(0, weaponNames.Length)];


        Meleeweapon.MaxDamage = Random.Range(5, 10);
        Meleeweapon.DamageVariance = Random.Range(.2f, .76f);
        Meleeweapon.MaxRange = BASE_MELEE_RANGE;
        Meleeweapon.TypeOfDamage = Weapon.DamageType.Slash;

        Meleeweapon.Icon = Resources.Load(MELEE_WEAPON_PATH + Meleeweapon.Name) as Texture2D;

        return Meleeweapon;
    }

}
public enum ItemType
{
    Armor,
    Weapon,
    Potion,
    Scroll
}
