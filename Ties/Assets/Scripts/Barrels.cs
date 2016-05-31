using UnityEngine;
using System.Collections;

public class Barrels : MonoBehaviour
{

    public LevelSystem playerLevel;


    public Transform t;
    private Transform player;
    float BarHit;
    int hp;
    int gold;
    int dongers;
    int ArmorValue;
   public WarriorClass warrior;
    Transform weapons1;
    CreateNewEquipment equipment;
    CreateNewWeapon weapon;

   
    

    void Awake()
    {
        ArmorValue = 5;
        hp = 100;
        BarHit = 3;
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        weapons1 = Resources.Load<Transform>("Coin");
        equipment = t.GetComponent<CreateNewEquipment>();
      //  weapon = t.GetComponent<CreateNewWeapon>();
    }

    private void Update()
    {
        //if (player)
        //    print(player.name + " is " + Distance().ToString() + " units from " + t.name);

        //else
        //    print("Player not found!");

        // print(BarHit);
        // print(hp);
        weapon = t.GetComponent<CreateNewWeapon>();

    }
    private float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }
    void golddrop()
    {
        {
            Instantiate(weapons1, transform.position, Quaternion.identity);

        }
       
    }
   void drop()
    {
        weapon.CreateWeapon();
    }
    void OnMouseDown()
    {
        if (Distance() < 3)
        {
            //  click.moveSpeed = 0;
            hp = hp - Mathf.Abs(ArmorValue - (warrior.basedamage + warrior.WeaponDamage));
        }

        if (hp <= 0)
        {
            int randomTemp = Random.Range(1, 100);
            if(randomTemp > 1)
            {

                //equipment.CreateEquipment();
                drop();
            } 
            playerLevel.exp = playerLevel.exp + 200;
           golddrop();
            
            Destroy(this.gameObject);


        }


    }
}

