using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour {

    public Item item;

    public void Update()
    {
        if (item.isCollectable)
        {
            if (FindObjectOfType<ItemManager>().itemName.text.Equals(item.name))
            {
                if (FindObjectOfType<ItemManager>().readyToCollect)
                {
                    FindObjectOfType<InventoryManager>().AddItemToVisualInventory(item.name);
                    this.gameObject.SetActive(false);
                    FindObjectOfType<ItemManager>().readyToCollect = false;
                }
            }
        }
    }

    public void OnMouseDown()
    {
       FindObjectOfType<ItemManager>().StartDescription(item);
       // if (item.isCollectable)
       // {
       //     FindObjectOfType<InventoryManager>().AddItemToVisualInventory(item.name);
       //
        //    this.gameObject.SetActive(false);
        //}
    }
}
