using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speechbubble : MonoBehaviour
{
    public Text b;

    public void addText(string input)
    {
        b.text = b.text + input;
    }

    public void clear()
    {
        b.text = "";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
