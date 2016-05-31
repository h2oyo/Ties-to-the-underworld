using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BaseItem : MonoBehaviour {

    public string itemName;
    public string itemDescription;
    public int itemID;
    public Transform itemIcon;
    public Texture2D ITEMicon;
    public int damage;
    public int strength;
    public int intellect;
    public int vit;
    public int dex;
    public enum ItemTypes
    {
        Weapon,
        Armor,
        Potions,
        Quest
    }

    public enum RarityType
    {
        Common,
        Magic,
        Rare,
        Legendary
    }

    public ItemTypes itemType;
    //public BaseItem(Dictionary<string, string> itemsDictionary)
    //{
    //    itemName = itemsDictionary["ItemName"];
    //    itemID = int.Parse(itemsDictionary["ItemID"]);
    //    itemType = (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes), itemsDictionary["itemType"].ToString());
    //}
    public Transform ItemIcon
    {
        get { return itemIcon; }
        set { itemIcon = value; }
    }
    public Texture2D ITEMICON
    {
        get { return ITEMicon; }
        set { ITEMicon = value; }
    }
    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }
    public string ItemDescripton
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }
    public  ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
    private RarityType rarityType;

    public RarityType Raritytype
    {
        get { return rarityType; }
        set { rarityType = value; }

    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }
    public int Vit
    {
        get { return vit; }
        set { vit = value; }
    }
    public int Dex
    {
        get { return dex; }
        set { dex = value; }
    }
}
