using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescriptionsManager : MonoBehaviour {

    public GameObject dialogbox;
    public Text descText;    

    public bool textActive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (textActive && Input.GetKey(KeyCode.Space))
        //{
        //    dialogbox.SetActive(false);
        //    textActive = false;
        //}
        
	}

    public void ShowBox(string text)
    {
        dialogbox.SetActive(true);
        textActive = true;
        descText.text = text;
        while (dialogbox && !Input.GetKey(KeyCode.Space)) { }
        //closeTextBox();
        descText.text = "You have collected: " + text;
        while (!Input.GetKey(KeyCode.Space)) { }
    }

    public void CollectItemText (string itemName)
    {
        descText.text = "You have collected " + itemName;
        StartCoroutine("WaitForClick");
        //closeTextBox();
    }

    public IEnumerator WaitForClick()
    {
        //

        yield return new WaitUntil(() => Input.GetKey(KeyCode.Space));
        // yield return new WaitForSeconds(5f);

    }

    public void closeTextBox()
    {
        dialogbox.SetActive(false);
        textActive = false;
    }

}