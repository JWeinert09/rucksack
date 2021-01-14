using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDemo : MonoBehaviour
{
   /* public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;
    public GameObject slot9;
    public GameObject slot10; */

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

    public int itemid = 0;
    private int value;
    private int weight;
    private string name;
    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        //Generieren von 10 Zufälligen Items
        for(int i = 0; i < 10; i++) {
            int random = (int) gameObject.GetComponent<RNGItemWahl>().generateNumber();
            spawnItem(random, i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)) {
            spawnItem(0, 0);
            spawnItem(2,1);
            spawnItem(7,2);
            Debug.Log("Event");
        } */
    }

    public Vector3 getSlot(int i) {
        switch(i) {
            case 0:
                return new Vector3(370, -180, 1);
            case 1:
                return new Vector3(370, -180, 1);
            case 2:
                return new Vector3(370, -180, 1);
            case 3:
                return new Vector3(370, -180, 1);
            case 4:
                return new Vector3(370, -180, 1);
            case 5:
                return new Vector3(370, -180, 1);
            case 6:
                return new Vector3(370, -180, 1);
            case 7:
                return new Vector3(370, -180, 1);
            case 8:
                return new Vector3(370, -180, 1);
            case 9:
                return new Vector3(370, -180, 1);
            default:
                Debug.Log("Error");
                return new Vector3(0,0,0);
        }
    }

    public Vector3 getNestSlot(int i) {
        switch(i) {
            case 1:
                return new Vector3(510, 358, 1);
            case 2:
                return new Vector3(510, 250, 1);
            case 3:
                return new Vector3(510, 135, 1);
            case 4:
                return new Vector3(510, 30, 1);
            case 5:
                return new Vector3(620, 358, 1);
            case 6:
                return new Vector3(620, 250, 1);
            case 7:
                return new Vector3(620, 135, 1);
            default:
                Debug.Log("Error");
                return new Vector3(0,0,0);    
        }  
    }

    public void spawnItem(int rand, int slot) {
        if(slot < 0 | slot > 10) {
            Debug.Log("Error");
            return;
        }

        switch(rand) {
            case 0:
                go = Instantiate(preRing, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Ring";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 18;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 1:
                go = Instantiate(preSchraube, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Schraube";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 2;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 2:
                go = Instantiate(preLöffel, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Löffel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 3;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 8; 
                itemid++;
                break;
            case 3:
                go = Instantiate(preBrille, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Brille";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 8;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 12; 
                itemid++;
                break;
            case 4:
                go = Instantiate(preKette, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Kette";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 20;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 14; 
                itemid++;
                break;
            case 5:
                go = Instantiate(preSpiegel, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Spiegel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 10;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 16; 
                itemid++;
                break;
            case 6:
                go = Instantiate(preDiadem, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Diadem";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 17;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 15; 
                itemid++;
                break;
            case 7:
                go = Instantiate(prePatrone, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Patrone";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 8; 
                itemid++;
                break;
            case 8:
                go = Instantiate(preMurmel, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Murmel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 4;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 2; 
                itemid++;
                break;
            case 9:
                go = Instantiate(preUSB, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "USB-Stick";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 6;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 6; 
                itemid++;
                break;
            case 10:
                go = Instantiate(preAlu, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Alufolie";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 13;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 1; 
                itemid++;
                break;
            case 11:
                go = Instantiate(preBrosche, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Brosche";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 5; 
                itemid++;
                break;
            case 12:
                go = Instantiate(preMünze, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Münze";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 12;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 2; 
                itemid++;
                break;
            case 13:
                go = Instantiate(preSchlAn, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Schlüsselanhänger";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 11;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 14:
                go = Instantiate(preGlas, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Glasscherben";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 7;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 15:
                go = Instantiate(preKronkorken, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Kronkorken";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 1; 
                itemid++;
                break;
            case 16:
                 go = Instantiate(preSchlüssel, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Schlüssel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 4;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 5; 
                itemid++;
                break;
            case 17:
                go = Instantiate(preGlü, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Glühbirne";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 2;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 18:
                go = Instantiate(preStift, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Stift";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 1;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 8; 
                itemid++;
                break;
            case 19:
                go = Instantiate(preVerschluss, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Coladosenverschluss";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 20:
                go = Instantiate(preNadel, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Sicherheitsnadel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 7;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 2; 
                itemid++;
                break;
            case 21:
                go = Instantiate(preTeelicht, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Teelicht";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 13;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 5; 
                itemid++;
                break;
            case 22:
                go = Instantiate(preGlö, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Glöckchen";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 15;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 23:
                go = Instantiate(preCD, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "CD";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 8;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 10; 
                itemid++;
                break;
            case 24:
                go = Instantiate(preHaarnadel, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Haarnadeln";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 6;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 25:
                go = Instantiate(prePerle, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Perle";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 15;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 26:
                go = Instantiate(preDose, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Leere Dose";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 20; 
                itemid++;
                break;
            case 27:
                go = Instantiate(preUhr, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Armbanduhr";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 17;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 16; 
                itemid++;
                break;
            case 28:
                go = Instantiate(prePyrit, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Pyrit";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 12; 
                itemid++;
                break;
            case 29:
                go = Instantiate(preQuartz, this.getSlot(slot), Quaternion.identity);
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Quartzkristall";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 16;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 13; 
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
