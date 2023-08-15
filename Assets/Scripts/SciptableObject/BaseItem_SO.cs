using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Item")]
public class BaseItem_SO : ScriptableObject
{
    public string Name;
    public Sprite Icon;
}
