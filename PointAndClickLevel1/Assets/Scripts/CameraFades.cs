using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFades : MonoBehaviour {

    public Animator Anim;
    private float fadeTime;
    private Image blackScreen;

	// Use this for initialization
	void Start () {
        fadeTime = 1.5f;
        blackScreen = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FadeToBlack ()
    {
        
        // blackScreen.CrossFadeAlpha(255f, fadeTime, false);
    }

    public void FadeInScreen ()
    {
        blackScreen.CrossFadeAlpha(0.1f, fadeTime, false);            
    }

     public IEnumerator Fade ()
    {
        Anim.SetBool("fade", true);
        yield return new WaitUntil(() => blackScreen.color.a == 1);

    }

}

