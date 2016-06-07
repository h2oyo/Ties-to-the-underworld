using UnityEngine;
using System.Collections;

namespace BurgZerArcade.ItemSystem
{
    public interface IISEquipable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        bool Equip();

	}
}
