using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<AllItems> _inventoryItems = new List<AllItems>();

    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(AllItems item)
    {
        if(!_inventoryItems.Contains(item))
        {
            _inventoryItems.Add(item);
        }
    }

    public enum AllItems
    {
        KeyRed,
        KeyBlue,
        KeyGreen
    }
}
