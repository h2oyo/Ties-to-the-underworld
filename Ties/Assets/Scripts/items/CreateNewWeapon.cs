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

       
     
        ChooseWeaponType();
        ChooseRarity();

        GameObject spawnedWeapon;

        switch(newWeapon.Raritytype)
        {
            case BaseItem.RarityType.Common:
                newWeapon.itemIcon = common;
                newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
                spawnedWeapon = Instantiate(common.gameObject, transform.position, Quaternion.identity) as GameObject;
                break;
            case BaseItem.RarityType.Magic:
                newWeapon.itemIcon = common;
                newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
                spawnedWeapon = Instantiate(magic.gameObject, transform.position, Quaternion.identity) as GameObject;
                break;
            case BaseItem.RarityType.Rare:
                newWeapon.itemIcon = rare;
                newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
                spawnedWeapon = Instantiate(rare.gameObject, transform.position, Quaternion.identity) as GameObject;
                break;
            case BaseItem.RarityType.Legendary:
                newWeapon.itemIcon = legdendary;
                newWeapon.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
                spawnedWeapon = Instantiate(legdendary.gameObject, transform.position, Quaternion.identity) as GameObject;
                break;
            default:
                Debug.LogError("This isn't supposed to happen. :(");
                return;
                break;

        }

        BaseWeapon spawnedWeaponData = spawnedWeapon.GetComponent<BaseWeapon>();
        spawnedWeaponData.dex = 9001;
        spawnedWeaponData.itemID = Random.Range(1, 100);
        spawnedWeaponData.ItemName = "W" + Random.Range(1, 101);
        spawnedWeaponData.ItemDescripton = "This is a new Weapon.";
    }

    void ChooseRarity()
    {
        int randomTemp = Random.Range(1, 101);
        if (randomTemp < 102)
        {
            newWeapon.Raritytype = BaseEquipment.RarityType.Common;
        }
        //else if (randomTemp > 61 && randomTemp < 85)
        //{
        //    newWeapon.Raritytype = BaseEquipment.RarityType.Magic;
        //}
        //else if (randomTemp > 86 && randomTemp < 95)
        //{
        //    newWeapon.Raritytype = BaseEquipment.RarityType.Rare;
        //}
        //else if (randomTemp > 102)
        //{
        //    newWeapon.Raritytype = BaseEquipment.RarityType.Legendary;
        //}

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
