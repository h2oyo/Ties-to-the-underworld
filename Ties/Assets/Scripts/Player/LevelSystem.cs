using UnityEngine;
using System.Collections;

public class LevelSystem : MonoBehaviour
{

    //We need 100 exp to level

    public int level;
    public int exp;
    public int statpoints;
    public WarriorClass warrior;

    void Start()
    {
        statpoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LevelUp();

    }

    void LevelUp()
    {
        if (exp >= 100)
        {
            level = level + 1;
            warrior.statpoints = warrior.statpoints + 5;

            exp = 0;
        }
    }
}
