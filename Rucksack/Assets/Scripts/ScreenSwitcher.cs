using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitcher : MonoBehaviour
{
    public void toMain() {
        SceneManager.LoadScene("Hauptmenu");
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

    public void quit() {
        Application.Quit();
    }
}
