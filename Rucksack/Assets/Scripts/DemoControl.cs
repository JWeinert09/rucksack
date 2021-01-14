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

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            this.sprechblase("Hallo Welt");
        }
    }

    public void start() {
        Debug.Log("Start");
    }

    public void stop() {
        Debug.Log("Stop");
    }

    public void pause() {
        Debug.Log("Pause");
    }

    public void sprechblase(string txt) {
        Text[] elster = bubble.GetComponentsInChildren<Text>();
        elster[0].text = txt;
        Instantiate(bubble,new Vector3(233, 188, 1), Quaternion.identity);
    }

    public void remove() {
        Destroy(bubble);
    } 
}
