using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public string currentLocation;
    public string bedroom = "bedroom";
    public string sittingroom = "sittingroom";
    public string kitchen = "kitchen";
    public string toilet = "toilet";
    public string garden = "garden";

    //private NavigationController theNavigationController;

	// Use this for initialization
	void Start () {
        // link to Navigation Controller Script
      //  theNavigationController = FindObjectOfType<NavigationController>();               
	}

    // These Methods Prepare the relevant Items for each Screen
    public void PrepareToiletScreen()
    {        
        Debug.Log(" Prepare Toilet Method");
        Debug.Log("Leaving " + currentLocation);
    }

    // These Methods Prepare the relevant Items for each Screen
    public void PrepareBedroomScreen ()
    {
        Debug.Log(" Prepare Bedroom Method");
        Debug.Log("Leaving " + currentLocation);
    }

    // These Methods Prepare the relevant Items for each Screen
    public void PrepareSittingRoomScreen()
    {
        Debug.Log(" Prepare Sitting Room Method");
        Debug.Log("Leaving " + currentLocation);
    }

    // These Methods Prepare the relevant Items for each Screen
    public void PrepareKitchenScreen()
    {
        Debug.Log(" Prepare Kitchen Method");
        Debug.Log("Leaving " + currentLocation);
    }

    // These Methods Prepare the relevant Items for each Screen
    public void PrepareGardenScreen()
    {
        Debug.Log(" Prepare Garden Method");
        Debug.Log("Leaving " + currentLocation);
    }    
}
