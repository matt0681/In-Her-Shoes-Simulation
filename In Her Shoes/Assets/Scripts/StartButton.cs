using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {
    
    public void goToFirstScene() {
        SceneManager.LoadScene("Card_1_House");
    }

}

