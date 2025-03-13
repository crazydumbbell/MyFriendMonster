using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Creates a menu option in Unity's asset creation menu
[CreateAssetMenu(fileName = "DictionaryItem", menuName = "DictionaryItem", order = 0)]
public class DictionaryItem : ScriptableObject
{
    public string Name;  // A field to store the item's name
    public int Cost;     // A field to store the item's cost
    public float Health;
    public string Weapon;
}