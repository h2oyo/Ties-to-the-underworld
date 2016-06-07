using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem.Editor
{
    public interface ISStacable 
    {
        int MaxStack { get; }

        int StackSize(int amount);

    }
}