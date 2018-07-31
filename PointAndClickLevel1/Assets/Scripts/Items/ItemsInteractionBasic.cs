using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemsInteractionBasic : MonoBehaviour {

    public bool collectable;
    public string itemDescription;
    public string itemName;

    private ItemDescriptionsManager iTM;

	// Use this for initialization
	void Start () {
        iTM = FindObjectOfType<ItemDescriptionsManager>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        iTM.ShowBox(itemDescription);
        //if (collectable)
        //{
            //iTM.CollectItemText(itemName);
            // gameObject.SetActive(false);
        //}        
    }


        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // flash highlight object
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // highlight object
    }
}
