using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    BaseWeapon newWeapon;
    Transform common;
    Transform magic;
    Transform rare;
    Transform legdendary;
    Texture2D Common;
    Texture2D Magic;
    Texture2D Rare;
    Texture2D Legdendary;
    Barrels bar;

    private string[] itemDes = new string[2] { "An new cool item", "A new lame item" };
    void Start()
    {
        common = Resources.Load<Transform>("Common");
        magic = Resources.Load<Transform>("Magic");
        rare = Resources.Load<Transform>("Rare");
        legdendary = Resources.Load<Transform>("Legdendary");
        Common = Resources.Load<Texture2D>("Common");
        Magic = Resources.Load<Texture2D>("Magic");
        Rare = Resources.Load<Texture2D>("Rare");
        Legdendary = Resources.Load<Texture2D>("Legdendary");
    }
    public void CreateWeapon()
    {
      
        newWeapon = new BaseWeapon();

        newWeapon.ItemName = "W" + Random.Range(1, 101);

        newWeapon.ItemDescripton = "This is a new Weapon.";

        newWeapon.ItemID = Random.Range(1, 100);
     
        ChooseWeaponType();
        ChooseRarity();
        if (newWeapon.Raritytype == BaseEquipment.RarityType.Common)
        {
            newWeapon.itemIcon = common;
            newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            Instantiate(common, transform.position, Quaternion.identity);
        }
        else if (newWeapon.Raritytype == BaseEquipment.RarityType.Magic)
        {
            newWeapon.itemIcon = magic;
            newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];

            ChooseStat();
            Instantiate(magic, transform.position, Quaternion.identity);
        }
        else if (newWeapon.Raritytype == BaseEquipment.RarityType.Rare)
        {
            newWeapon.itemIcon = rare;
            newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            ChooseStat();
            ChooseStat();
            Instantiate(rare, transform.position, Quaternion.identity);
        }
        else if (newWeapon.Raritytype == BaseEquipment.RarityType.Legendary)
        {
            newWeapon.itemIcon = legdendary;
            newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            ChooseStat();
            ChooseStat();
            ChooseStat();
            Instantiate(legdendary, transform.position, Quaternion.identity);
        }
    }

    void ChooseRarity()
    {
        int randomTemp = Random.Range(1, 101);
        if (randomTemp < 60)
        {
            newWeapon.Raritytype = BaseEquipment.RarityType.Common;
        }
        else if (randomTemp > 61 && randomTemp < 85)
        {
            newWeapon.Raritytype = BaseEquipment.RarityType.Magic;
        }
        else if (randomTemp > 86 && randomTemp < 95)
        {
            newWeapon.Raritytype = BaseEquipment.RarityType.Rare;
        }
        else if (randomTemp < 101)
        {
            newWeapon.Raritytype = BaseEquipment.RarityType.Legendary;
        }

    }

   void ChooseStat()
    {
        int randomTemp = Random.Range(1, 4);
        newWeapon.Intellect = newWeapon.Intellect;
        if (randomTemp == 1)
        {
            newWeapon.Vit = newWeapon.Vit + Random.Range(1, 11);
            print(newWeapon.Vit);
        }
        else if (randomTemp == 2)
        {
            newWeapon.Dex = newWeapon.Dex + Random.Range(1, 11);
            print(newWeapon.Dex);
        }
        else if (randomTemp == 3)
        {
            newWeapon.Strength = newWeapon.Strength + Random.Range(1, 11);
            print(newWeapon.Strength);
        }
        else if (randomTemp == 4)
        {
            newWeapon.Intellect = newWeapon.Intellect + Random.Range(1, 11);
            print(newWeapon.Intellect);
        }
    }

    void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 4);
        if(randomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.Sword;
        }
        else if (randomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.Staff;
        }
        else if (randomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.Sheild;
        }
    }
}
