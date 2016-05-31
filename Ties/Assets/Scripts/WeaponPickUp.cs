using UnityEngine;
using System.Collections;

public class WeaponPickUp : MonoBehaviour {
    private Transform t;
    private Transform player;

    Inventory inv;
 
    BaseWeapon Weapon;
    CreateNewWeapon id;
    // Use this for initialization
    void Start () {
        t = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        inv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
      
        Weapon = t.GetComponent<BaseWeapon>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public float Distance()
    {
        return Vector3.Distance(t.position, player.position);
    }
    void OnMouseDown()
    {
        inv.AddItem(Weapon.itemID);
       // Destroy(this.gameObject);

    }
}
