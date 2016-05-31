using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {

    private BaseEquipment newEquipmet;
    private string[] itemNames = new string[4] { "Common", "Great", "Amazing", "Insane" };
    private string[] itemDes = new string[2] { "An new cool item", "A new lame item" };
    Transform common;
    Transform magic;
    Transform rare;
    Transform legdendary;


    void Start () {
        
        common = Resources.Load<Transform>("Common");
        magic = Resources.Load<Transform>("Magic");
        rare = Resources.Load<Transform>("Rare");
        legdendary = Resources.Load<Transform>("Legdendary");


        //Debug.Log(newEquipmet.ItemName);
        //Debug.Log(newEquipmet.ItemDescripton);
        //Debug.Log(newEquipmet.ItemID.ToString());
        //Debug.Log(newEquipmet.EquipmentType.ToString());
        //Debug.Log(newEquipmet.Vit.ToString());
        //Debug.Log(newEquipmet.Dex.ToString());
        //Debug.Log(newEquipmet.Strength.ToString());
        //Debug.Log(newEquipmet.Intellect.ToString());
        //Debug.Log(newEquipmet.Raritytype);

        
    }
    void Update()
    {
    }
    public void CreateEquipment()
    {
        newEquipmet = new BaseEquipment();
        newEquipmet.ItemName = itemNames[Random.Range(0, 3)] + " Item";
  
        ChooseItemType();
        ChooseRarity();
        if (newEquipmet.Raritytype == BaseEquipment.RarityType.Common)
        {
          
            newEquipmet.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            Instantiate(common, transform.position, Quaternion.identity);
        } else if (newEquipmet.Raritytype == BaseEquipment.RarityType.Magic)
        {
          
            newEquipmet.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            ChooseStat();
            Instantiate(magic, transform.position, Quaternion.identity);
        }
        else if (newEquipmet.Raritytype == BaseEquipment.RarityType.Rare)
        {
          
            newEquipmet.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            ChooseStat();
            ChooseStat();
            Instantiate(rare, transform.position, Quaternion.identity);
        }
        else if (newEquipmet.Raritytype == BaseEquipment.RarityType.Legendary)
        {
       
            newEquipmet.ItemDescripton = itemDes[Random.Range(0, itemDes.Length)];
            ChooseStat();
            ChooseStat();
            ChooseStat();
            Instantiate(legdendary, transform.position, Quaternion.identity);
        }


    }
    public void ChooseRarity()
    {
        int randomTemp = Random.Range(1, 101);
        if (randomTemp < 60)
        {
            newEquipmet.Raritytype = BaseEquipment.RarityType.Common;
        }
        else if (randomTemp > 61 && randomTemp < 85)
        {
            newEquipmet.Raritytype = BaseEquipment.RarityType.Magic;
        }
        else if (randomTemp > 86 && randomTemp < 95)
        {
            newEquipmet.Raritytype = BaseEquipment.RarityType.Rare;
        }
        else  if (randomTemp < 101)
        {
            newEquipmet.Raritytype = BaseEquipment.RarityType.Legendary;
        }

    }

    public void ChooseStat()
    {
        int randomTemp = Random.Range(1, 4);
        newEquipmet.Vit = newEquipmet.Vit;
        newEquipmet.Dex = newEquipmet.Dex;
        newEquipmet.Strength = newEquipmet.Strength;
        newEquipmet.Intellect = newEquipmet.Intellect;
        if (randomTemp == 1)
        {
            newEquipmet.Vit = newEquipmet.Vit + Random.Range(1, 11);
            print(newEquipmet.Vit);
        }else if (randomTemp == 2)
        {
            newEquipmet.Dex = newEquipmet.Dex + Random.Range(1, 11);
            print(newEquipmet.Dex);
        }
        else if (randomTemp == 3)
        {
            newEquipmet.Strength = newEquipmet.Strength + Random.Range(1, 11);
            print(newEquipmet.Strength);
        }
        else if (randomTemp == 4)
        {
            newEquipmet.Intellect = newEquipmet.Intellect + Random.Range(1, 11);
            print(newEquipmet.Intellect);
        }

    }
    private void ChooseItemType()
    {
        int randomTemp = Random.Range(1, 9);
        if(randomTemp == 1)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Head;
        }
        else if (randomTemp == 2)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Shoulders;
        }
        else if (randomTemp == 3)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Chest;
        }
        else if (randomTemp == 4)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Legs;
        }
        else if (randomTemp == 5)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Feet;
        }
        else if (randomTemp == 6)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Neck;
        }
        else if (randomTemp == 7 )
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Ring;
        }
        else if (randomTemp == 8)
        {
            newEquipmet.EquipmentType = BaseEquipment.EquipmentTypes.Earring;
        }

    }
	// Update is called once per frame

}
