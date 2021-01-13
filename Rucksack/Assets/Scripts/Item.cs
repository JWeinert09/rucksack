using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;
    public GameObject slot9;
    public GameObject slot10;

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

    public GameObject getSlot(int i) {
        switch(i) {
            case 0:
                return slot1;
            case 1:
                return slot2;
            case 2:
                return slot3;
            case 3:
                return slot4;
            case 4:
                return slot5;
            case 5:
                return slot6;
            case 6:
                return slot7;
            case 7:
                return slot8;
            case 8:
                return slot9;
            case 9:
                return slot10;
            default:
                Debug.Log("Error");
                return null;
        }
    }

    public void spawnItem(int rand, int slot) {
        if(slot < 0 | slot > 10) {
            Debug.Log("Error");
            return;
        }

        switch(rand) {
            case 0:
                go = Instantiate(preRing, new Vector3(385, -80, 44), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Ring";
                go.GetComponent<ItemValues>().value = 18;
                go.GetComponent<ItemValues>().weight = 3;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Ring";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 18;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 1:
                go = Instantiate(preSchraube, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Schraube";
                go.GetComponent<ItemValues>().value = 2;
                go.GetComponent<ItemValues>().weight = 4;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Schraube";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 2;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 2:
                go = Instantiate(preLöffel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Löffel";
                go.GetComponent<ItemValues>().value = 3;
                go.GetComponent<ItemValues>().weight = 8;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Löffel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 3;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 8; 
                itemid++;
                break;
            case 3:
                go = Instantiate(preBrille, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Brille";
                go.GetComponent<ItemValues>().value = 8;
                go.GetComponent<ItemValues>().weight = 12;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Brille";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 8;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 12; 
                itemid++;
                break;
            case 4:
                go = Instantiate(preKette, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Kette";
                go.GetComponent<ItemValues>().value = 20;
                go.GetComponent<ItemValues>().weight = 14;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Kette";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 20;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 14; 
                itemid++;
                break;
            case 5:
                go = Instantiate(preSpiegel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Spiegel";
                go.GetComponent<ItemValues>().value = 10;
                go.GetComponent<ItemValues>().weight = 16;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Spiegel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 10;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 16; 
                itemid++;
                break;
            case 6:
                go = Instantiate(preDiadem, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Diadem";
                go.GetComponent<ItemValues>().value = 17;
                go.GetComponent<ItemValues>().weight = 15;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Diadem";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 17;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 15; 
                itemid++;
                break;
            case 7:
                go = Instantiate(prePatrone, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Patrone";
                go.GetComponent<ItemValues>().value = 5;
                go.GetComponent<ItemValues>().weight = 8;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Patrone";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 8; 
                itemid++;
                break;
            case 8:
                go = Instantiate(preMurmel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Murmel";
                go.GetComponent<ItemValues>().value = 4;
                go.GetComponent<ItemValues>().weight = 2;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Murmel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 4;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 2; 
                itemid++;
                break;
            case 9:
                go = Instantiate(preUSB, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "USB-Stick";
                go.GetComponent<ItemValues>().value = 6;
                go.GetComponent<ItemValues>().weight = 6;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "USB-Stick";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 6;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 6; 
                itemid++;
                break;
            case 10:
                go = Instantiate(preAlu, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Alufolie";
                go.GetComponent<ItemValues>().value = 13;
                go.GetComponent<ItemValues>().weight = 1;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Alufolie";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 13;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 1; 
                itemid++;
                break;
            case 11:
                go = Instantiate(preBrosche, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Brosche";
                go.GetComponent<ItemValues>().value = 14;
                go.GetComponent<ItemValues>().weight = 5;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Brosche";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 5; 
                itemid++;
                break;
            case 12:
                go = Instantiate(preMünze, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Münze";
                go.GetComponent<ItemValues>().value = 12;
                go.GetComponent<ItemValues>().weight = 2;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Münze";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 12;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 2; 
                itemid++;
                break;
            case 13:
                go = Instantiate(preSchlAn, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Schlüsselanhänger";
                go.GetComponent<ItemValues>().value = 11;
                go.GetComponent<ItemValues>().weight = 3;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Schlüsselanhänger";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 11;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 14:
                go = Instantiate(preGlas, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Glasscherben";
                go.GetComponent<ItemValues>().value = 7;
                go.GetComponent<ItemValues>().weight = 4;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Glasscherben";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 7;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 15:
                go = Instantiate(preKronkorken, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Kronkorken";
                go.GetComponent<ItemValues>().value = 5;
                go.GetComponent<ItemValues>().weight = 1;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Kronkorken";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 1; 
                itemid++;
                break;
            case 16:
                 go = Instantiate(preSchlüssel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Schlüssel";
                go.GetComponent<ItemValues>().value = 4;
                go.GetComponent<ItemValues>().weight = 5;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Schlüssel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 4;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 5; 
                itemid++;
                break;
            case 17:
                go = Instantiate(preGlü, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Glühbirne";
                go.GetComponent<ItemValues>().value = 2;
                go.GetComponent<ItemValues>().weight = 3;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Glühbirne";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 2;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 18:
                go = Instantiate(preStift, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Stift";
                go.GetComponent<ItemValues>().value = 1;
                go.GetComponent<ItemValues>().weight = 8;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Stift";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 1;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 8; 
                itemid++;
                break;
            case 19:
                go = Instantiate(preVerschluss, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Coladosenverschluss";
                go.GetComponent<ItemValues>().value = 5;
                go.GetComponent<ItemValues>().weight = 3;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Coladosenverschluss";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 5;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 20:
                go = Instantiate(preNadel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Sicherheitsnadel";
                go.GetComponent<ItemValues>().value = 7;
                go.GetComponent<ItemValues>().weight = 2;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Sicherheitsnadel";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 7;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 2; 
                itemid++;
                break;
            case 21:
                go = Instantiate(preTeelicht, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Teelicht";
                go.GetComponent<ItemValues>().value = 13;
                go.GetComponent<ItemValues>().weight = 5;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Teelicht";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 13;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 5; 
                itemid++;
                break;
            case 22:
                go = Instantiate(preGlö, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Glöckchen";
                go.GetComponent<ItemValues>().value = 15;
                go.GetComponent<ItemValues>().weight = 4;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Glöckchen";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 15;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 23:
                go = Instantiate(preCD, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "CD";
                go.GetComponent<ItemValues>().value = 8;
                go.GetComponent<ItemValues>().weight = 10;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "CD";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 8;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 10; 
                itemid++;
                break;
            case 24:
                go = Instantiate(preHaarnadel, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Haarnadeln";
                go.GetComponent<ItemValues>().value = 6;
                go.GetComponent<ItemValues>().weight = 4;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Haarnadeln";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 6;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 4; 
                itemid++;
                break;
            case 25:
                go = Instantiate(prePerle, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Perle";
                go.GetComponent<ItemValues>().value = 15;
                go.GetComponent<ItemValues>().weight = 3;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Perle";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 15;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 3; 
                itemid++;
                break;
            case 26:
                go = Instantiate(preDose, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Leere Dose";
                go.GetComponent<ItemValues>().value = 14;
                go.GetComponent<ItemValues>().weight = 20;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Leere Dose";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 20; 
                itemid++;
                break;
            case 27:
                go = Instantiate(preUhr, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Armbanduhr";
                go.GetComponent<ItemValues>().value = 17;
                go.GetComponent<ItemValues>().weight = 16;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Armbanduhr";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 17;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 16; 
                itemid++;
                break;
            case 28:
                go = Instantiate(prePyrit, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Pyrit";
                go.GetComponent<ItemValues>().value = 14;
                go.GetComponent<ItemValues>().weight = 12;
                go.GetComponent<ItemValues>().id = itemid;
                gameObject.GetComponent<GlobalValues>().givenNames[itemid] = "Pyrit";
                gameObject.GetComponent<GlobalValues>().givenValues[itemid] = 14;
                gameObject.GetComponent<GlobalValues>().givenWeights[itemid] = 12; 
                itemid++;
                break;
            case 29:
                go = Instantiate(preQuartz, new Vector3(0,0,0), Quaternion.identity);
                go.transform.parent = this.getSlot(slot).transform;
                go.GetComponent<ItemValues>().name = "Quartzkristall";
                go.GetComponent<ItemValues>().value = 16;
                go.GetComponent<ItemValues>().weight = 13;
                go.GetComponent<ItemValues>().id = itemid;
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
