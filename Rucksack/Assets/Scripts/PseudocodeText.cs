using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PseudocodeText : MonoBehaviour
{
    public Text t;
    public Text elster;

    //Anfügen von Text an den Pseudocode
    public void addText(string input) {
        t.text = t.text + input;
    }

    //Leeren des Pseudocodefensters 
    public void clear() {
        t.text = "";
    }
}
