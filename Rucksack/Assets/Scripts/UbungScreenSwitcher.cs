using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UbungScreenSwitcher : MonoBehaviour
{
    public bool activePopup = false;

    public void toMain() {
        activePopup = gameObject.GetComponent<GlobalValues>().getPop();
        if(!activePopup) {
            SceneManager.LoadScene("Hauptmenu");
        }
        
    }

    public void toTut() {
        SceneManager.LoadScene("Tutorial");
    }

    public void toExcer() {
        SceneManager.LoadScene("Ubung");
    }

    public void toCredits() {
        SceneManager.LoadScene("Mitwirkende");
    }

    public void toWiki() {
        SceneManager.LoadScene("Wiki");
    }

    public void toDemo() {
        SceneManager.LoadScene("Demo");
    }

    public void quit() {
        Application.Quit();
    }
}
