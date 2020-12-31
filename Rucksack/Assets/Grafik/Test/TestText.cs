using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestText : MonoBehaviour
{
    public Text t;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bu_Start() {
        t.text = t.text + " Start.";
        //GameObject.Find("Text").text = GameObject.Find("Text").text + " Start.";
    }

    public void bu_Stop() {
        t.text = t.text + " Stop.";
        //GameObject.Find("Text").text = GameObject.Find("Text").text + " Start.";
    }
}
