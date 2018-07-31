using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    Vector3 originalPosition;

    private void Start()
    {
        // record original position
        originalPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnMouseDrag()
    {
        // mousePosition is the cordinates of the mouse pointer in the context of the Game World 
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
        // the position of the item is the same as the mouse position
        gameObject.transform.position = new Vector3(mousePosition.x, mousePosition.y, -2f);
    }


    private void OnMouseUp()
    {       
        // when the mouse button is release the item returns to the inventory
        gameObject.transform.position = originalPosition;        
    }
}