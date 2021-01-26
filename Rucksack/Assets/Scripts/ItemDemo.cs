using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemDemo : MonoBehaviour
{
    //Slots der Gegenstandsleiste
    public GameObject islot1;
    public GameObject islot2;
    public GameObject islot3;
    public GameObject islot4;
    public GameObject islot5;
    public GameObject islot6;
    public GameObject islot7;
    public GameObject islot8;
    public GameObject islot9;
    public GameObject islot10;

    //Slots des Nests
    public GameObject nslot1;
    public GameObject nslot2;
    public GameObject nslot3;
    public GameObject nslot4;
    public GameObject nslot5;
    public GameObject nslot6;
    public GameObject nslot7;

    //Prefabs der Gegenstände
    public GameObject preRing;
    public GameObject preAlu;
    public GameObject preBrille;
    public GameObject preBrosche;
    public GameObject preCD;
    public GameObject preGlö;
    public GameObject preGlü;
    public GameObject preKronkorken;
    public GameObject preLöffel;
    public GameObject preMurmel;
    public GameObject preMünze;
    public GameObject preNadel;
    public GameObject prePatrone;
    public GameObject prePerle;
    public GameObject preSchraube;
    public GameObject preSpiegel;
    public GameObject preTeelicht;
    public GameObject preVerschluss;
    public GameObject preKette;
    public GameObject prePyrit;
    public GameObject preQuartz;
    public GameObject preGlas;
    public GameObject preSchlüssel;
    public GameObject preUSB;
    public GameObject preHaarnadel;
    public GameObject preSchlAn;
    public GameObject preDose;
    public GameObject preStift;
    public GameObject preDiadem;
    public GameObject preUhr;

    public GameObject[] objects = new GameObject[10];

    public int itemid = 0;
    private int value;
    private int weight;
    private string name;
    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        //Generieren von 10 Zufälligen Items
       int[] rng = this.generator(); 
        for(int i = 0; i <= 9; i++) {
            this.spawnItem(rng[i], i);
        }
    }

    //Auswahl des Slots der Gegenstandsleiste
    public GameObject getSlot(int i) {
        switch(i) {
            case 0:
                return islot1;
            case 1:
                return islot2;
            case 2:
                return islot3;
            case 3:
                return islot4;
            case 4:
                return islot5;
            case 5:
                return islot6;
            case 6:
                return islot7;
            case 7:
                return islot8;
            case 8:
                return islot9;
            case 9:
                return islot10;
            default:    
                Debug.Log("Error");
                return null;
        }
    }

    //Auswahl des Slots des Nestes
    public GameObject getNestSlot(int i) {
        switch(i) {
            case 0:
                return nslot1;
            case 1:
                return nslot2;
            case 2:
                return nslot3;
            case 3:
                return nslot4;
            case 4:
                return nslot5;
            case 5:
                return nslot6;
            case 6:
                return nslot7;
            default:
                Debug.Log("Error");
                return null;    
        }  
    }

    //Generieren von 10 Zufallszahlen
     public int[] generator() {
        int[] rng = new int[10];
        int r = 1;
        for(int i = 0; i < rng.Length; i++) {
            for(int j = 0; j < 100; j++) {//Verbesserung des Ergebnises, macht Dopplungen unwahrscheinlicher -> Dauert zu lange für komplettes Filtern
                r = gameObject.GetComponent<RNGItemWahl>().generateNumber();
                if(rng.Contains(r)) {
                }
                else {
                    rng[i] = r;
                }
            }
            
        }
        return rng;
    }

    //Erschaffen der Gegenstände für die Demo
    public void spawnItem(int rand, int slot) {
        if(slot < 0 | slot > 10) {
            Debug.Log("Error");
            return;
        }

        switch(rand) {
            case 0:
                go = Instantiate(preRing, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Ring";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 18;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 3;
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 1:
                go = Instantiate(preSchraube, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Schraube";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 2;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 4; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 2:
                go = Instantiate(preLöffel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Löffel";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 3;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 8;
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go; 
                itemid++;
                break;
            case 3:
                go = Instantiate(preBrille, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Brille";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 8;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 12;
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go; 
                itemid++;
                break;
            case 4:
                go = Instantiate(preKette, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Kette";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 20;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 14; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 5:
                go = Instantiate(preSpiegel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Spiegel";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 10;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 16; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 6:
                go = Instantiate(preDiadem, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Diadem";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 17;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 15; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 7:
                go = Instantiate(prePatrone, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Patrone";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 8; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 8:
                go = Instantiate(preMurmel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Murmel";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 4;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 2; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 9:
                go = Instantiate(preUSB, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "USB-Stick";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 6;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 6; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 10:
                go = Instantiate(preAlu, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Alufolie";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 13;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 1; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 11:
                go = Instantiate(preBrosche, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Brosche";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 5; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 12:
                go = Instantiate(preMünze, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Münze";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 12;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 2; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 13:
                go = Instantiate(preSchlAn, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Schlüsselanhänger";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 11;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 3; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 14:
                go = Instantiate(preGlas, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Glasscherben";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 7;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 4;
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go; 
                itemid++;
                break;
            case 15:
                go = Instantiate(preKronkorken, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Kronkorken";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 1; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 16:
                 go = Instantiate(preSchlüssel, new Vector3(0,0,0), Quaternion.identity);
                 go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Schlüssel";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 4;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 5; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 17:
                go = Instantiate(preGlü, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Glühbirne";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 2;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 3; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 18:
                go = Instantiate(preStift, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Stift";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 1;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 8; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 19:
                go = Instantiate(preVerschluss, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Coladosenverschluss";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 3; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 20:
                go = Instantiate(preNadel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Sicherheitsnadel";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 7;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 2; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 21:
                go = Instantiate(preTeelicht, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Teelicht";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 13;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 5; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 22:
                go = Instantiate(preGlö, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Glöckchen";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 15;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 4; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 23:
                go = Instantiate(preCD, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "CD";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 8;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 10; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 24:
                go = Instantiate(preHaarnadel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Haarnadeln";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 6;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 4; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 25:
                go = Instantiate(prePerle, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Perle";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 15;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 3; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 26:
                go = Instantiate(preDose, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Leere Dose";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 20; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 27:
                go = Instantiate(preUhr, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Armbanduhr";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 17;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 16; 
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go;
                itemid++;
                break;
            case 28:
                go = Instantiate(prePyrit, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Pyrit";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 12;
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go; 
                itemid++;
                break;
            case 29:
                go = Instantiate(preQuartz, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                gameObject.GetComponent<DemoGlobalValues>().givenNames[itemid] = "Quartzkristall";
                gameObject.GetComponent<DemoGlobalValues>().givenValues[itemid] = 16;
                gameObject.GetComponent<DemoGlobalValues>().givenWeights[itemid] = 13;
                gameObject.GetComponent<DemoGlobalValues>().objects[itemid] = go; 
                itemid++;
                break;
            default: 
                this.name = "Error";
                this.value = 20;
                this.weight = 20;
                break;    
        }
    }

    public int getVal() {
        return this.value;
    }

    public int getWei() {
        return this.weight;
    }

    public string getNam() {
        return this.name;
    }

    public GameObject getGO() {
        return go;
    }
}
