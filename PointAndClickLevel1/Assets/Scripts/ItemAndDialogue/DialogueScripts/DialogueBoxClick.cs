using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBoxClick : MonoBehaviour {

    private void OnMouseDown()
    {
        FindObjectOfType<DialogueManager>().DisplayNextSentence();
    }
}
