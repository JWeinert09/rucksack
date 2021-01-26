using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLinks : MonoBehaviour {

    //Aufrufen der im Wiki angegebenen Links
    public void openlink1() {
        Debug.Log("link");
        Application.OpenURL("https://www.fastleansmart.com/blog/das-rucksackproblem/");
    }

    public void openlink2() {
        Application.OpenURL("https://www.bigdata-insider.de/der-greedy-algorithmus-a-843043/");
    }

     public void openlink3() {
        Application.OpenURL("http://www.tigerjython.ch/download/rucksack.pdf");
    }

     public void openlink4() {
        Application.OpenURL("https://www.uni-trier.de/fileadmin/fb4/prof/INF/TIN/Folien/GTI_III/ss_2010/VL8.pdf");
    }

     public void openlink5() {
        Application.OpenURL("https://www.youtube.com/watch?v=hs6MNddIUtw");
    }

     public void openlink6() {
        Application.OpenURL("https://www.youtube.com/watch?v=wMVf8lOn-Lc");
    }    
}
