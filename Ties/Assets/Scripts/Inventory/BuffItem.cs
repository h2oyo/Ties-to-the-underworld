using UnityEngine;
using System.Collections;

public class BuffItem : Item {

    private Hashtable buffs;

    public BuffItem()
    {
        buffs = new Hashtable();
    }

    public BuffItem(Hashtable ht)
    {
        buffs = ht;
    }

    public void AddBuff(BaseStatItem stat, int mod)
    {
        buffs.Add(stat.name, mod);
    }
}
