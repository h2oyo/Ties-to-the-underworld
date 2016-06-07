using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem
{
    public interface IISWeapon 
    {
        int MinDamage { get; set; }

        int Attack();


	}
}
