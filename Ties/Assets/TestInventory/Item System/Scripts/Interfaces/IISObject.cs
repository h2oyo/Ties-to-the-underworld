using UnityEngine;
using System.Collections;
namespace BurgZerArcade.ItemSystem
{
    public class IISObject : MonoBehaviour
    {
       public string Name { get; set; }
        int Value { get; set; }
        Sprite Icon { get; set; }

        int Burden { get; set; }

        ISQuality Quality { get; set; }
    }
}