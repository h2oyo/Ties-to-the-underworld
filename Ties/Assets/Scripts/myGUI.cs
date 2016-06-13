using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class myGU : MonoBehaviour {
    public float lootWindowHeight = 90;

    public float buttonWidth = 40;
    public float buttonHeight = 40;

    private float _offset = 10;

    private List<BaseItem> _lootItems;

    private const int LOOT_WINDOW_ID = 0;

    private Rect _lootWindowRect = new Rect(0, 0, 0,0);
	// Use this for initialization
	void Start () {
        _lootItems = new List<BaseItem>();
        Populate();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onGUI()
    {
        _lootWindowRect = GUI.Window(LOOT_WINDOW_ID, new Rect(_offset, Screen.height - (_offset + lootWindowHeight), Screen.width - (_offset * 2), lootWindowHeight), LootWindow, "Loot Window");
    }
    void LootWindow(int id)
    {
        for(int cnt=0; cnt <_lootItems.Count; cnt++)
        {
            GUI.Button(new Rect(buttonWidth * cnt, 0, buttonWidth, buttonHeight), cnt.ToString());
        }
    }

    private void Populate()
    {
        for (int cnt = 0; cnt < 25; cnt++)
            _lootItems.Add(new BaseItem());
    }
}
