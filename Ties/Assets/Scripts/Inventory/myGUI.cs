﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class myGUI : MonoBehaviour {
    public float lootWindowHeight = 90;

    public float buttonWidth = 40;
    public float buttonHeight = 40;
    public float closeButtonWidth = 20;
    public float closeButtonHeight = 20;

    private float _offset = 10;


    private bool _displayLootWindow = false;
    private const int LOOT_WINDOW_ID = 0;
    private Rect _lootWindowRect = new Rect(0, 0, 0,0);
    private Vector2 _lootWindowSlider = Vector2.zero;
    public static ChestOpens chest;


    private bool _displayInventoryWindow = true;
    private const int INVENTORY_WINDOW_ID = 1;
    private Rect _InventoryWindowRect = new Rect(10, 10, 170, 265);
    private int _inventoryRows = 6;
    private int _inventoryCols = 4;


    public GUISkin mySkin;



    // Use this for initialization
    void Start () {

	}
	
    private void OnEnable()
    {
        Messenger.AddListener("DisplayLoot", DisplayLoot);
        Messenger.AddListener("ToggleInventory", ToggleInventoryWindow);
        Messenger.AddListener("CloseChest", ClearWindow);
       
    }

    private void OnDisable()
    {
        Messenger.RemoveListener("DisplayLoot", DisplayLoot);
        Messenger.RemoveListener("ToggleInventory", ToggleInventoryWindow);
        Messenger.RemoveListener("CloseChest", ClearWindow);

    }
    // Update is called once per frame
    void Update () {
	
	}

    void OnGUI()
    {
        GUI.skin = mySkin;
        if(_displayInventoryWindow)
            _InventoryWindowRect = GUI.Window(INVENTORY_WINDOW_ID, _InventoryWindowRect, InventoryWindow,"Inventory");
        if (_displayLootWindow)
            _lootWindowRect = GUI.Window(LOOT_WINDOW_ID, new Rect(_offset, Screen.height - (_offset + lootWindowHeight), Screen.width - (_offset * 2), lootWindowHeight), LootWindow, "Loot Window", "box");
    }
   private void LootWindow(int id)
    {
        GUI.skin = mySkin;
       

        if (GUI.Button(new Rect(_lootWindowRect.width - _offset * 2, 0, closeButtonWidth, closeButtonHeight), "x", "Close Window Button")){
            ClearWindow();
            if (chest == null)
                return;

            if(chest.loot.Count == 0)
            {
                ClearWindow();
                return;
            }
        }
        _lootWindowSlider = GUI.BeginScrollView(new Rect(_offset * .5f, 15, _lootWindowRect.width - 10, 70), _lootWindowSlider, new Rect(0, 0, (chest.loot.Count * buttonWidth) + _offset, buttonHeight + _offset));
        

        for(int cnt=0; cnt < chest.loot.Count; cnt++)
        {
           if (GUI.Button(new Rect(buttonWidth * cnt, 0, buttonWidth, buttonHeight), chest.loot[cnt].Name))
            {
                chest.loot.RemoveAt(cnt);
            }
        }
        GUI.EndScrollView();
    }

    private void DisplayLoot()
    {
        _displayLootWindow = true;
    }
    //private void PopulateChest(int x)

    //{

    //    for (int cnt = 0; cnt < x; cnt++)
    //        _lootItems.Add(new Item());
    //    _displayLootWindow = true;
    //}

    private void ClearWindow()
    {
        _displayLootWindow = false;


        chest.GetComponent<ChestOpens>().OnMouseUp();
        chest = null;


    }


    public void InventoryWindow(int id)
    {
        for(int y = 0; y < _inventoryRows; y++)
        {
            for(int x = 0; x < _inventoryCols; x++)
            {
                GUI.Button(new Rect(5 + (x * buttonWidth), 20 + (y * buttonHeight), buttonWidth, buttonHeight), (x+ y * _inventoryCols).ToString());
            }
        }
        GUI.DragWindow();
    }

    public void ToggleInventoryWindow()
    {
        _displayInventoryWindow = !_displayInventoryWindow;
    }
}
