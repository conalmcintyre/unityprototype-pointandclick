using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    private Queue<string> sentences;
    
    public GameObject dialogueBox;
    public Text nameText;
    public Text dialogueText;
    
    // Use this for initialization
    void Start () {
        sentences = new Queue<string>();
    }
	
    public void StartDialogue (Dialogue dialogue)
    {          
        // Clear Queue
        if (!(sentences.Count == 0))
        {
            sentences.Clear();
        }
        
        // Create New Queue of sentences
        foreach (string sentence in dialogue.scentences)
        {
            sentences.Enqueue(sentence);
        }     
                
        // Set dialogueBox as active
        dialogueBox.gameObject.SetActive(true);
        // Set Name 
        nameText.text = dialogue.name;
        // Display first scentence in queue
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
 
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {        
        dialogueBox.gameObject.SetActive(false);         
    }
       
}
