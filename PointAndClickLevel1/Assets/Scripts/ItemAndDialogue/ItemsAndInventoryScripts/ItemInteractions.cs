using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractions : MonoBehaviour {

    public string interactsWith;
    private bool isTouching;
    
    // Use this for initialization
	void Start () {
        isTouching = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (isTouching && Input.GetMouseButtonUp(0))
        {
            Debug.Log("I have interacted with " + interactsWith);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == interactsWith)
        {
            isTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == interactsWith)
        {
            isTouching = false;
        }
    }
}
