using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public LinkedList<string> inventory;
    public Queue<string> sentences;

    public GameObject itemTextBox;
    public Text itemName;
    public Text itemDescription;

    private bool isCollectable;
    // used in ItemTrigger to control when items are added to the Inventory
    public bool readyToCollect;

    int i = 0;

    void Start()
    {
        inventory = new LinkedList<string>();
        // Use this for initialization
        sentences = new Queue<string>();
    }

    public void StartDescription(Item item)
    {
        // Clear Queue
        if (!(sentences.Count == 0))
        {
            sentences.Clear();
        }        

        // Create New Queue of sentences
        foreach (string sentence in item.scentences)
        {
            sentences.Enqueue(sentence);
        }
        // Set value for isCollectable
        isCollectable = item.isCollectable;
        // Set dialogueBox as active
        itemTextBox.gameObject.SetActive(true);
        // Set Name 
        itemName.text = item.name;
        // Display first scentence in queue
        DisplayNextSentence();
    }

    public bool DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            CloseDialogueBox();
            return true;
        }
        else if (sentences.Count == 1)
        {
            // used in ItemTrigger
            readyToCollect = true;
        }

        string sentence = sentences.Dequeue();
        itemDescription.text = sentence;
        return false;
    }

    public void CloseDialogueBox()
    {        
        itemTextBox.gameObject.SetActive(false);
        // FindObjectOfType<InventoryManager>().AddItemToVisualInventory(itemName.text);
    }

    public void AddToInventory ()
    {
        if (isCollectable)
        {
            inventory.AddLast(itemName.text);
            isCollectable = false;
        }

        foreach (var word in inventory)
        {
            Debug.Log(i + ": This is in the inventory: " + word);

        }
        i++;
        Debug.Log("Total Items: " + inventory.ToString());
    }
}
