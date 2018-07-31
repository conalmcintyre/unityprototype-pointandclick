using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTextBoxClick : MonoBehaviour {

    public bool mouseDown = false;

    private void OnMouseDown()
    {
        bool isTextBoxClosed = FindObjectOfType<ItemManager>().DisplayNextSentence();
                
        if (isTextBoxClosed)
        {
            // run method to add item to inventory and remove from screen
            FindObjectOfType<ItemManager>().AddToInventory();            
        }
    }
}
