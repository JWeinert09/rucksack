using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PseudocodeText : MonoBehaviour
{
    public Text t;

    public void addText(string input) {
        t.text = t.text + input;
    }

    public void clear() {
        t.text = "";
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
