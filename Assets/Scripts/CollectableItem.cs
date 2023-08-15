using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectableItem : BaseItem
{

    [SerializeField]
    private CollectableItem collectableItem;

    public override string Name => collectableItem.Name;

    public override Sprite Icon => collectableItem.Icon;


    public enum CollectableItemTypes
    {
        NONE,
        APPLE
    }

    public void Collected()
    {
        gameObject.SetActive(false);
    }

}
