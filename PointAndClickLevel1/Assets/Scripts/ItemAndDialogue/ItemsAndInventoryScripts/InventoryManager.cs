using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public LinkedList<string> inventoryList;
    public GameObject inventoryFrame;

    // Sprites to add to the Inventory
    public Sprite shoes;
    public Sprite sword;
    public Sprite key;
    public Sprite apple;
    public Sprite shovel;
    public Sprite bone;
    public Sprite floppyDisk;
    public Sprite carKeys;

    // Question Marks to Update
    [SerializeField]
    public GameObject[] arrySlots;
    // used to increment through arraySlots as the slots are filled
    int i = 0;
    

    // Use this for initialization
    void Start () {
        inventoryList = new LinkedList<string>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddItemToVisualInventory (string itemName)
    {
        // inventoryList = FindObjectOfType<ItemManager>().inventory;
        //Sprite questionMark = arrySlots[i].GetComponent<SpriteRenderer>().sprite;
        
        switch (itemName)
        {
            case "Shoes":
                // update sprite
                arrySlots[i].GetComponent<SpriteRenderer>().sprite = shoes;
                // update size of sprite
                arrySlots[i].GetComponent<Transform>().localScale = new Vector3(2f, 2f, 1);
                // update boxcollider size - the scale affects the boxcollider size
                arrySlots[i].GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                break;
            case "Sword":
                // update sprite
                arrySlots[i].GetComponent<SpriteRenderer>().sprite = sword;
                // update size of sprite
                arrySlots[i].GetComponent<Transform>().localScale = new Vector3(2f, 2f, 1);
                // update boxcollider size - the scale affects the boxcollider size
                arrySlots[i].GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                // set tag of inventory item
                arrySlots[i].tag = "Sword";
                break;

            // GARAGE ITEMS
            case "Shovel":
                // update sprite
                arrySlots[i].GetComponent<SpriteRenderer>().sprite = shovel;
                // update size of sprite
                arrySlots[i].GetComponent<Transform>().localScale = new Vector3(0.3f, 0.3f, 1);
                // update boxcollider size - the scale affects the boxcollider size
                arrySlots[i].GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                // set tag of inventory item
                arrySlots[i].tag = "Shovel";
                break;
            // SITTINGROOM ITEMS
            case "Floppy Disk":
                // update sprite
                arrySlots[i].GetComponent<SpriteRenderer>().sprite = floppyDisk;
                // update size of sprite
                arrySlots[i].GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 1);
                // update boxcollider size - the scale affects the boxcollider size
                arrySlots[i].GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                // set tag of inventory item
                arrySlots[i].tag = "Floppy Disk";
                break;
            // TOILET ITEMS
            case "Car Keys":
                // update sprite
                arrySlots[i].GetComponent<SpriteRenderer>().sprite = carKeys;
                // update size of sprite
                arrySlots[i].GetComponent<Transform>().localScale = new Vector3(0.1f, 0.1f, 1);
                // update boxcollider size - the scale affects the boxcollider size
                arrySlots[i].GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
                // set tag of inventory item
                arrySlots[i].tag = "Car Keys";
                break;
        }
        Debug.Log("Index: " + i);
        i++;
    }

    public void RemoveItemToVisualInventory()
    {
        inventoryList = FindObjectOfType<ItemManager>().inventory;
    }
}
