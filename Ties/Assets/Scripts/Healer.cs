using UnityEngine;
using System.Collections;
public class Healer : MonoBehaviour
{
    public bool healerMenu;
    WarriorClass warrior;
    Transform player;
    // Use this for initialization

    private float Distance()
    { return Vector3.Distance(player.position, gameObject.transform.position); }
    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0) && Distance() < 3)
            healerMenu = true;
    }
    void Start()
    {
        healerMenu = false;

        player = GameObject.FindGameObjectWithTag("Player").transform;

        warrior = player.GetComponent<WarriorClass>();
    }

    // Update is called once per frame
    void Update()
    {




    }
}