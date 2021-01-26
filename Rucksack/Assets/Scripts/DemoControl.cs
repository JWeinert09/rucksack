using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoControl : MonoBehaviour
{
    public GameObject bubble;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Start-Knopf
    public void start() {
        Debug.Log("Start");
        Time.timeScale = 1f;
    }

    //Pause-Knopf
    public void pause() {
        Debug.Log("Pause");
        Time.timeScale = 0f;
    }
    //Setzen des Textes in der Sprechblase der Elster
    public void sprechblase(string txt) {
        Text[] elster = bubble.GetComponentsInChildren<Text>();
        elster[0].text = txt;
        Instantiate(bubble,new Vector3(233, 188, 1), Quaternion.identity);
    }
}
