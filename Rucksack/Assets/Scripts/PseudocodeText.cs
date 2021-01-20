using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PseudocodeText : MonoBehaviour
{
    public Text t;
    public Text elster;

    public void elsterSay(string s) {
        elster.text = s;
    }

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
