using UnityEngine;
using System.Collections;
public class LevelSystem : MonoBehaviour
{
    //We need 100 exp to level
    public int level;
    public int exp;
    public int statpoints;
    public WarriorClass warrior;
    int expToLvL;
    void Start()
    {
        statpoints = 0;
        expToLvL = 100;
    }
    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }
    void LevelUp()
    {
        if (exp >= expToLvL)
        {
            level = level + 1;
            warrior.statpoints = warrior.statpoints + 5;
            warrior.skillpoints = warrior.skillpoints + 1;
            expToLvL = expToLvL * 2;
            exp = 0;
        }

    }
}
