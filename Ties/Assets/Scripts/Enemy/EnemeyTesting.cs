using UnityEngine;
using System.Collections;

public class EnemeyTesting : MonoBehaviour {

    
    int moveSpeed = 3;
    int rotationSpeed = 3;
    int ArmorValue;
    int hp;

    Transform target; // target is the player on this script
    Transform mytransform;  // this is the enemy's transform
    public WarriorClass warrior;
    public LevelSystem playerLevel;


    // Use this for initialization
    void Start ()
    {
        hp = 200;
        ArmorValue = 1;
        mytransform = transform;
        target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
     //   if (Vector3.Distance(target.position, mytransform.position) < 5)
      //  {
      //      mytransform.rotation = Quaternion.Slerp(mytransform.rotation, Quaternion.LookRotation(target.position - mytransform.position), rotationSpeed * Time.deltaTime);
      //      mytransform.position += mytransform.forward * moveSpeed * Time.deltaTime;
      //  }

    }
    private float Distance()
    {
        return Vector3.Distance(mytransform.position, target.position);
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
            playerLevel.exp = playerLevel.exp + 200;
            // golddrop();
            Destroy(this.gameObject);


        }

    }

   }
