using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavigationController : MonoBehaviour {

    public GameObject bedRoom;
    public GameObject kitchen;
    public GameObject garden;
    public GameObject sittingRoom;
    public GameObject toilet;
    public GameObject garage;
      
    private LevelController theLevelController;
    //private CameraFades theCameraFades;

	// Use this for initialization
	void Start () {
        theLevelController = FindObjectOfType<LevelController>();
        // theCameraFades = FindObjectOfType<CameraFades>();
        this.goToBedroom();      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void DeactivateAllBackgrounds ()
    {
        kitchen.SetActive(false);
        sittingRoom.SetActive(false);
        toilet.SetActive(false);
        garden.SetActive(false);
        bedRoom.SetActive(false);
        garage.SetActive(false);
    }

    public void goToBedroom()
    {
        // Fade To Black
        //theCameraFades.FadeToBlack();
        // Deactivate All Items

        // Activate Bedroom Items
        theLevelController.PrepareBedroomScreen();
        // Deactivate All Background Images
        DeactivateAllBackgrounds();
        // Activate Bedroom Image
        bedRoom.SetActive(true);
        // Set new Current Location
        theLevelController.currentLocation = theLevelController.bedroom;
        Debug.Log(theLevelController.currentLocation);
        // Fade in Gamescreen
        //theCameraFades.FadeInScreen();

    }

    public void goToSittingRoom()
    {
        // Fade To Black
        //theCameraFades.FadeToBlack();
        // Deactivate All Items

        // Activate Items
        theLevelController.PrepareSittingRoomScreen();
        // Deactivate All Background Images
        DeactivateAllBackgrounds();

        sittingRoom.SetActive(true);

        theLevelController.currentLocation = theLevelController.sittingroom;
        Debug.Log(theLevelController.currentLocation);

        //theCameraFades.FadeInScreen();
    }

    public void goToKitchen()
    {
        // Fade To Black
        //theCameraFades.FadeToBlack();
        // Deactivate All Items

        // Activate Items
        theLevelController.PrepareKitchenScreen();
        // Deactivate All Background Images
        DeactivateAllBackgrounds();

        kitchen.SetActive(true);

        theLevelController.currentLocation = theLevelController.kitchen;
        Debug.Log(theLevelController.currentLocation);

        //theCameraFades.FadeInScreen();
    }

    public void goToToilet()
    {
        // Fade To Black
        //theCameraFades.FadeToBlack();
        // Deactivate All Items

        // Activate Items
        theLevelController.PrepareToiletScreen();
        // Deactivate All Background Images
        DeactivateAllBackgrounds();

        toilet.SetActive(true);

        theLevelController.currentLocation = theLevelController.toilet;
        Debug.Log(theLevelController.currentLocation);

        //theCameraFades.FadeInScreen();
    }

    public void goToGarden()
    {
        // Fade To Black
        //theCameraFades.FadeToBlack();
        // Deactivate All Items

        // Activate Items
        theLevelController.PrepareGardenScreen();
        // Deactivate All Background Images
        DeactivateAllBackgrounds();

        garden.SetActive(true);

        theLevelController.currentLocation = theLevelController.garden;
        Debug.Log(theLevelController.currentLocation);

        //theCameraFades.FadeInScreen();
    }

    public void goToGarage()
    {
        // Fade To Black
        //theCameraFades.FadeToBlack();
        // Deactivate All Items

        // Activate Items
        theLevelController.PrepareGarageScreen();
        // Deactivate All Background Images
        DeactivateAllBackgrounds();

        garage.SetActive(true);

        theLevelController.currentLocation = theLevelController.garage;
        Debug.Log(theLevelController.currentLocation);

        //theCameraFades.FadeInScreen();
    }


    public void MoveLeft ()
    {
        Debug.Log("Click Left");
        switch (theLevelController.currentLocation)
        {
            case "toilet": goToBedroom();
                break;
            case "bedroom": goToSittingRoom();
                break;
            case "sittingroom": goToKitchen();
                break;
            case "kitchen": goToGarden();
                break;
            case "garden": goToGarage();
                break;
            default: goToGarage();
                break;
        }
    }

    public void MoveRight()
    {
        switch (theLevelController.currentLocation)
        {
            case "garage": goToGarden();
                break;
            case "garden": goToKitchen();
                break;
            case "kitchen": goToSittingRoom();
                break;
            case "sittingroom": goToBedroom();
                break;
            case "bedroom": goToToilet();
                break;
            default: goToToilet();
                break;
        }
    }

}
