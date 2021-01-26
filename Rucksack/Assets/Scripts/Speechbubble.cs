using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speechbubble : MonoBehaviour
{
    public Text b;

    //Anfügen von Text an Sprechblase
    public void addText(string input)
    {
        b.text = b.text + input;
    }

    //Leeren der Sprechblase
    public void clear()
    {
        b.text = "";
    }
}
