using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WarriorClass : MonoBehaviour
{

    private static List<Item> _inventory = new List<Item>();

    public static List<Item> Inventory{
        get{ return _inventory; }
        }
    private static Item _equipedWeapon;
    public static Item EquipedWeapon
    {
        get { return _equipedWeapon; }
        set { _equipedWeapon = value; }
    }

    public int exp, level;
    public int str, dex, vit, mag;
    public int HealthPoints, ManaPoints, MaxHealth;
    public int basedamage;
    public int damageReduction;
    public int WeaponDamage;
    public int weapon;
    public bool StatsMenu = false;
    public int damageTaken;
    public int statpoints;
    public int healthpots, manapots;
    float sw;
    float sh;
    public int maxhealthpots, maxmanapots;
    public bool isActive;
    float temptime;
    public int manaSpent;
    public int gold;
    CoinPickup coin;
    public bool sharpenActive;
    public bool bashActive;
    public bool casted;
    public int tempDam;

   
    // Use this for initialization
    void Start ()
    {
        
        level = 1;
        exp = 0;

        str = 12;
        dex = 8;
        vit = 10;
        mag = 4;
        StatsMenu = false;
        healthpots = 5;
        gold = 50;
        //hard value for testing only, this should come from the weapon tables.

        casted = false;
        bashActive = false;
        tempDam = WeaponDamage;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (EquipedWeapon != null)
        {
            WeaponDamage = EquipedWeapon.MaxDamage;
        }
        else
        {
            WeaponDamage = 0;
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            if (!StatsMenu)
            {
                StatsMenu = true;
            }
            else
            {
                StatsMenu = false;
                Time.timeScale = 1;
            }
        }
        MaxHealth = (vit * 5);
        HealthPoints = MaxHealth - damageTaken;
        if(HealthPoints > MaxHealth)
        {
            HealthPoints = MaxHealth;
        }
     
        ManaPoints = (mag * 5) - manaSpent;
        basedamage = str / 2;
        if (ManaPoints <= 0) { ManaPoints = 0; }
        //  Debug.Log(basedamage);
        sharpen();
        if(Input.GetButtonUp("Toggle Character Window"))
        {
            Messenger.Broadcast("ToggleCharacterWindow");
        }
        if (Input.GetButtonUp("ToggleInventory"))
        {
            Messenger.Broadcast("ToggleInventory");
        }

    }

    public void sharpen()
    {
        temptime += Time.deltaTime;
        if (Input.GetMouseButtonDown(1) && sharpenActive == true)
        {
            temptime = 0;
            manaSpent += 5;
            if (casted == false) { casted = true; WeaponDamage += 2; }
        }
        if (temptime >= 5) { WeaponDamage = tempDam; casted = false; temptime = 0; }

    }
    public void bash()
    {
   
        ManaPoints = mag * 5;
        basedamage = str / 2;

        basedamage = basedamage * 2;
        manaSpent += 3;

    }
    void OnGUI()
    {
        GUI.Button(new Rect(0, 455, 150, 50), "GOLD:" + gold);
        if (GUI.Button(new Rect(450, 600, 200, 50), "HpPots:" + healthpots))
        {
            if (healthpots > 0 && damageTaken > 0)
            {
                healthpots = healthpots - 1;
                damageTaken = damageTaken - 10;
            }

        }
        GUI.Button(new Rect(0, 575, 150, 50), "Health:" + HealthPoints);
        GUI.Button(new Rect(1000, 575, 100, 50), "Mana:" + ManaPoints);

        
        //on top right side have a button to show main menu toggle 
        if (GUI.Button(new Rect(1060, 0, 40, 40), "S:" + statpoints))
        {
            if (!StatsMenu)
            {
                StatsMenu = true;
                Time.timeScale = 0;
            }
            else
            {
                StatsMenu = false;
                Time.timeScale = 1;
            }
        }
        if (GUI.Button(new Rect(0, 475, 250, 50), "Bash"))
        {
            bashActive = true;
            sharpenActive = false;
        }
        if (GUI.Button(new Rect(0, 175, 50, 50), "Sharpen"))
        {
            sharpenActive = true;
            bashActive = false;
        }
        if (StatsMenu)
        {
            //resume button
            if (GUI.Button(new Rect(450, 200, 200, 50), "Stregth:" + str))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    str = str + 1;
                }

            }
            //Exit to Menu button
            if (GUI.Button(new Rect(450, 260, 200, 50), "Dex:" + dex))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    dex = dex + 1;
                }
            }
            //Quit button
            if (GUI.Button(new Rect(450, 320, 200, 50), "Vit:" + vit))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    vit = vit + 1;
                }
            }
            if (GUI.Button(new Rect(450, 380, 200, 50), "Mag:" + mag))
            {
                if (statpoints > 0)
                {
                    statpoints = statpoints - 1;
                    mag = mag + 1;
                }
            }
         
        }
    }



}
