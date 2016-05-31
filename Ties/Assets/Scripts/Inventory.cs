using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Inventory : MonoBehaviour
{
    public int slotsX, slotsY;
    public GUISkin skin;
    public List<BaseItem> inventory = new List<BaseItem>();
    public List<BaseItem> slots = new List<BaseItem>();
    private ItemDatabase database;
    public bool showInventory;
    private bool showTooltip;
    private string tooltip;




    public bool draggingItem;
    private BaseItem draggedItem;
    private int prevIndex;

    // Use this for initialization
    void Start()
    {
      
        for (int i = 0; i < (slotsX * slotsY); i++)
        {
            slots.Add(new BaseItem());
            inventory.Add(new BaseItem());
        }
        database = GameObject.FindGameObjectWithTag("Item Database").GetComponent<ItemDatabase>();
        showInventory = false;
    }
    void Update()
    {

        if (Input.GetButtonDown("Inventory"))
        {

            showInventory = !showInventory;
  
        }
        
        
    }
    void OnGUI()
    {
        tooltip = "";
        GUI.skin = skin;
        if (showInventory)
        {
            DrawInventory();
            if (showTooltip)
                GUI.Box(new Rect(Event.current.mousePosition.x + 15, Event.current.mousePosition.y, 200, 200), tooltip, skin.GetStyle("Tooltip"));

        }
      
        if (draggingItem)
        {
            GUI.DrawTexture(new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y, 50, 50), draggedItem.ITEMicon);
        }
    }

    void DrawInventory()
    {
   
            Event e = Event.current;
        int i = 0;
        for (int y = 0; y < slotsX; y++)
        {
            for (int x = 0; x < slotsY; x++)
            {
                Rect slotRect = new Rect(x * 60, y * 60, 50, 50);
                GUI.Box(slotRect, "", skin.GetStyle("Slot"));
                slots[i] = inventory[i];
                if (slots[i].itemName != null)
                {
                    GUI.DrawTexture(slotRect, slots[i].ITEMicon);
                    if (slotRect.Contains(e.mousePosition))
                    {
                        CreateTooltip(slots[i]);
                        showTooltip = true;
                        if (e.button == 0 && e.type == EventType.mouseDrag && !draggingItem)
                        {
                            draggingItem = true;
                            prevIndex = i;
                            draggedItem = slots[i];
                            inventory[i] = new BaseItem();
                        }
                        if (e.type == EventType.mouseUp && draggingItem)
                        {
                            inventory[prevIndex] = inventory[i];
                            inventory[i] = draggedItem;
                            draggingItem = false;
                            draggedItem = null;
                        }
                    }

                }
                else
                {
                    if (slotRect.Contains(e.mousePosition))
                    {
                        if (e.type == EventType.mouseUp && draggingItem)
                        {
                            inventory[i] = draggedItem;
                            draggingItem = false;
                            draggedItem = null;
                        }
                    }
                }
                if (e.isMouse && e.type == EventType.mouseDown && e.button == 1)
                {
                    if (slots[i].ItemType == BaseItem.ItemTypes.Potions)
                    {
                        UseConsumable(slots[i], i, true);
                    }
                }
                if (tooltip == "")
                {
                    showTooltip = false;
                }

                i++;
            }
        }
    }

    string CreateTooltip(BaseItem item)
    {
        tooltip = "<color=#fffff>" + item.itemName + "</color>\n" + item.itemDescription;
        return tooltip;

    }
    void RemoveItem(int id)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemID == id)
            {
                inventory[i] = new BaseItem();
                break;
            }
        }
    }


   public void AddItem(int id)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].itemName == null)
            {
                for (int j = 0; j < database.items.Count; j++)
                {
                    if (database.items[j].itemID == id)
                    {
                        inventory[i] = database.items[j];
                    }
                }
                break;
            }
        }

    }

    bool InventoryContains(int id)
    {
        bool result = false;
        for (int i = 0; i < inventory.Count; i++)
        {
            result = inventory[i].itemID == id;
            if (result)
            {
                break;
            }
        }
        return result;
    }
    private void UseConsumable(BaseItem item, int slot, bool deleteItem)
    {
        switch (item.itemID)
        {
            case 2:
                {
                    
                    break;
                }
        }
        if (deleteItem)
        {
            inventory[slot] = new BaseItem();
        }
    }
}
