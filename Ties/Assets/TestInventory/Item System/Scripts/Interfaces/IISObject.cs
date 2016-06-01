using UnityEngine;
using System.Collections;
namespace BurgZerArcade.ItemSystem
{
    public class IISObject : MonoBehaviour
    {
        string ISName { get; set; }
        int ISValue { get; set; }
        Sprite ISIcon { get; set; }

        int ISBurden { get; set; }

        ISQuality ISQuality { get; set; }
    }
}