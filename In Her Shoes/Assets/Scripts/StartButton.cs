using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    
    public void goToHouseScene() {
        SceneManager.LoadScene("Card_1_House");
    }

    public void goToBedroomScene() {
        SceneManager.LoadScene("Bedroom");
    }

    public void goToInterrogationScene() {
        SceneManager.LoadScene("Interogation room");
    }

    public void goToMainMenuScene() {
        SceneManager.LoadScene("Main Menu");
    }

    public void goToOperatingScene() {
        SceneManager.LoadScene("Operating Room");
    }

}

