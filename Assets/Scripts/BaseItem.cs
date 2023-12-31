using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseItem : MonoBehaviour
{
    public abstract string Name { get; }
    public abstract Sprite Icon { get; }
}
