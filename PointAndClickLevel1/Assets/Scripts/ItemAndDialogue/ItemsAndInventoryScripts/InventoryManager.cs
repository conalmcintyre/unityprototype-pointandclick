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
        }
        Debug.Log("Index: " + i);
        i++;
    }

    public void RemoveItemToVisualInventory()
    {
        inventoryList = FindObjectOfType<ItemManager>().inventory;
    }
}
