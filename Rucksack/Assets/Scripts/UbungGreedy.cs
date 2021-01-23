using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbungGreedy : MonoBehaviour
{
     public string greedy(int[] weight, int[] value, string[] name, string[] chosenItems) {
        //int[] r; //RNG
        //int[] value; //Übergebene Werte
        //int[] weight; //Hier auch
        float[] valueperweight = new float[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] weightsubtracted;
        int[] valueadded;
        float[] sortierung;
        int[] item;
        int[] block;
        /*
        //RandomNumberGenerator
        int r1 = Random.Range(1, 30);
        int r2 = Random.Range(1, 30);
        while (r2 == r1)
        { r2 = Random.Range(1, 30); };
        int r3 = Random.Range(1, 30);
        while (r3 == r1 || r3 == r2)
        { r3 = Random.Range(1, 30); };
        int r4 = Random.Range(1, 30);
        while (r4 == r1 || r4 == r2 || r4 == r3)
        { r4 = Random.Range(1, 30); };
        int r5 = Random.Range(1, 30);
        while (r5 == r1 || r5 == r2 || r5 == r3 || r5 == r4)
        { r5 = Random.Range(1, 30); };
        int r6 = Random.Range(1, 30);
        while (r6 == r1 || r6 == r2 || r6 == r3 || r6 == r4 || r6 == r5)
        { r6 = Random.Range(1, 30); };
        int r7 = Random.Range(1, 30);
        while (r7 == r1 || r7 == r2 || r7 == r3 || r7 == r4 || r7 == r5 || r7 == r6)
        { r7 = Random.Range(1, 30); };
        int r8 = Random.Range(1, 30);
        while (r8 == r1 || r8 == r2 || r8 == r3 || r8 == r4 || r8 == r5 || r8 == r6 || r8 == r7)
        { r8 = Random.Range(1, 30); };
        int r9 = Random.Range(1, 30);
        while (r9 == r1 || r9 == r2 || r9 == r3 || r9 == r4 || r9 == r5 || r9 == r6 || r9 == r7 || r9 == r8)
        { r9 = Random.Range(1, 30); };
        int r10 = Random.Range(1, 30);
        while (r10 == r1 || r10 == r2 || r10 == r3 || r10 == r4 || r10 == r5 || r10 == r6 || r10 == r7 || r10 == r8 || r10 == r9)
        { r10 = Random.Range(1, 30); };

        r = new int[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        value = new int[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        weight = new int[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        valueperweight = new float[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        weightsubtracted = new int[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        sortierung = new float[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        valueadded = new int[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        item = new int[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10 };
        block = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        */

        //Itemliste
        
        for (int i = 0; i < 10; i++)
        {
           /* switch (r[i])
            {
                case 1:
                    value[i] = 18;
                    weight[i] = 3;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 2:
                    value[i] = 2;
                    weight[i] = 4;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 3:
                    value[i] = 3;
                    weight[i] = 8;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 4:
                    value[i] = 8;
                    weight[i] = 12;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 5:
                    value[i] = 20;
                    weight[i] = 14;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 6:
                    value[i] = 10;
                    weight[i] = 16;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 7:
                    value[i] = 17;
                    weight[i] = 15;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 8:
                    value[i] = 5;
                    weight[i] = 8;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 9:
                    value[i] = 4;
                    weight[i] = 2;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 10:
                    value[i] = 6;
                    weight[i] = 6;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 11:
                    value[i] = 13;
                    weight[i] = 1;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 12:
                    value[i] = 14;
                    weight[i] = 5;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 13:
                    value[i] = 12;
                    weight[i] = 2;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 14:
                    value[i] = 11;
                    weight[i] = 3;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 15:
                    value[i] = 7;
                    weight[i] = 4;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 16:
                    value[i] = 5;
                    weight[i] = 1;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 17:
                    value[i] = 4;
                    weight[i] = 5;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 18:
                    value[i] = 2;
                    weight[i] = 3;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 19:
                    value[i] = 1;
                    weight[i] = 8;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 20:
                    value[i] = 5;
                    weight[i] = 3;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 21:
                    value[i] = 7;
                    weight[i] = 2;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 22:
                    value[i] = 13;
                    weight[i] = 5;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 23:
                    value[i] = 15;
                    weight[i] = 4;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 24:
                    value[i] = 8;
                    weight[i] = 10;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 25:
                    value[i] = 6;
                    weight[i] = 4;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 26:
                    value[i] = 15;
                    weight[i] = 3;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 27:
                    value[i] = 14;
                    weight[i] = 20;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 28:
                    value[i] = 17;
                    weight[i] = 16;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 29:
                    value[i] = 14;
                    weight[i] = 12;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                case 30:
                    value[i] = 16;
                    weight[i] = 13;
                    Debug.Log("Item " + (i + 1) + " hat die Werte: Value:" + value[i] + " Weight:" + weight[i]);
                    break;
                default:
                    break;
            } */
            valueperweight[i] = value[i] / weight[i];
            //sortierung[i] = valueperweight[i];

        }

        //Item Value/Weight Sortierung
        float perHelp;
        int sorthelp; //String hinzufügen
        string namehelp;
        for (int i = 9; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (valueperweight[j] < valueperweight[j + 1])
                {
                    perHelp = valueperweight[j];
                    valueperweight[j] = valueperweight[j+1];
                    valueperweight[j+1] = valueperweight[j];

                    sorthelp = value[j];
                    value[j] = value[j + 1];
                    value[j + 1] = sorthelp;

                    sorthelp = weight[j];
                    weight[j] = weight[j + 1];
                    weight[j + 1] = sorthelp;

                    namehelp = name[j];
                    name[j] = name[j + 1];
                    name[j + 1] = namehelp;
                }
            }
        }
        /*
        int block1 = 0;
        int block2 = 0;
        int block3 = 0;
        int block4 = 0;
        int block5 = 0;
        int block6 = 0;
        int block7 = 0;
        int block8 = 0;
        int block9 = 0;
        int block10 = 0;
        */
        /*
        //Value/Weight auf Items zurückführen
        for (int i = 0; i < 10; i++)
        {
            if (sortierung[i] == valueperweight[0] && block[i] == block1)
            {
                weightsubtracted[i] = weight[0];
                valueadded[i] = value[0];
                item[i] = 1;
                block[i] = 1;
                block1 = 1;
            }
            if (sortierung[i] == valueperweight[1] && block[i] == block2)
            {
                weightsubtracted[i] = weight[1];
                valueadded[i] = value[1];
                item[i] = 2;
                block[i] = 2;
                block2 = 2;
            }
            if (sortierung[i] == valueperweight[2] && block[i] == block3)
            {
                weightsubtracted[i] = weight[2];
                valueadded[i] = value[2];
                item[i] = 3;
                block[i] = 3;
                block3 = 3;
            }
            if (sortierung[i] == valueperweight[3] && block[i] == block4)
            {
                weightsubtracted[i] = weight[3];
                valueadded[i] = value[3];
                item[i] = 4;
                block[i] = 4;
                block4 = 4;
            }
            if (sortierung[i] == valueperweight[4] && block[i] == block5)
            {
                weightsubtracted[i] = weight[4];
                valueadded[i] = value[4];
                item[i] = 5;
                block[i] = 5;
                block5 = 5;
            }
            if (sortierung[i] == valueperweight[5] && block[i] == block6)
            {
                weightsubtracted[i] = weight[5];
                valueadded[i] = value[5];
                item[i] = 6;
                block[i] = 6;
                block6 = 6;
            }
            if (sortierung[i] == valueperweight[6] && block[i] == block7)
            {
                weightsubtracted[i] = weight[6];
                valueadded[i] = value[6];
                item[i] = 7;
                block[i] = 7;
                block7 = 7;
            }
            if (sortierung[i] == valueperweight[7] && block[i] == block8)
            {
                weightsubtracted[i] = weight[7];
                valueadded[i] = value[7];
                item[i] = 8;
                block[i] = 8;
                block8 = 8;
            }
            if (sortierung[i] == valueperweight[8] && block[i] == block9)
            {
                weightsubtracted[i] = weight[8];
                valueadded[i] = value[8];
                item[i] = 9;
                block[i] = 9;
                block9 = 9;
            }
            if (sortierung[i] == valueperweight[9] && block[i] == block10)
            {
                weightsubtracted[i] = weight[9];
                valueadded[i] = value[9];
                item[i] = 10;
                block[i] = 10;
                block10 = 10;
            }
        } */

        //Greedyalgorithmusberechnung
        int anzahl = 0;
        int chosen = 0;
        string ausgabe = "Vom Algorithmus wurden \n\n";
        int maxweight = 50;
        int endvalue = 0;       //Sortiertes Value
        bool[] algoItemsChosen = new bool[10];
        if (0 <= (maxweight - weight[0]) & value[0] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[0];
            endvalue = endvalue + value[0];
            ausgabe = ausgabe + name[0] + "\n";
            chosen++;
            algoItemsChosen[0] = true;
            //Debug.Log("Item " + item[0] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        } 
        if (0 <= (maxweight - weight[1]) & value[1] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[1];
            endvalue = endvalue + value[1];
            ausgabe = ausgabe + name[1] + "\n";
            chosen++;
            algoItemsChosen[1] = true;
            //Debug.Log("Item " + item[1] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[2]) & value[2] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[2];
            endvalue = endvalue + value[2];
            ausgabe = ausgabe + name[2] + "\n";
            chosen++;
            algoItemsChosen[2] = true;
            //Debug.Log("Item " + item[2] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[3]) & value[3] != 0 & chosen < 7)  
        {
            maxweight = maxweight - weight[3];
            endvalue = endvalue + value[3];
            ausgabe = ausgabe + name[3] + "\n";
            chosen++;
            algoItemsChosen[3] = true;
            //Debug.Log("Item " + item[3] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[4]) & value[4] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[4];
            endvalue = endvalue + value[4];
            ausgabe = ausgabe + name[4] + "\n";
            chosen++;
            algoItemsChosen[4] = true;
            //Debug.Log("Item " + item[4] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[5]) & value[5] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[5];
            endvalue = endvalue + value[5];
            ausgabe = ausgabe + name[5] + "\n";
            chosen++;
            algoItemsChosen[5] = true;
            //Debug.Log("Item " + item[5] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[6]) & value[6] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[6];
            endvalue = endvalue + value[6];
            ausgabe = ausgabe + name[6] + "\n";
            chosen++;
            algoItemsChosen[6] = true;
            //Debug.Log("Item " + item[6] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[7]) & value[7] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[7];
            endvalue = endvalue + value[7];
            ausgabe = ausgabe + name[7] + "\n";
            chosen++;
            algoItemsChosen[7] = true;
            //Debug.Log("Item " + item[7] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[8]) & value[8] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[8];
            endvalue = endvalue + value[8];
            ausgabe = ausgabe + name[8] + "\n";
            chosen++;
            algoItemsChosen[8] = true;
            //Debug.Log("Item " + item[8] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        }
        if (0 <= (maxweight - weight[9]) & value[9] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[9];
            endvalue = endvalue + value[9];
            ausgabe = ausgabe + name[9] + "\n";
            chosen++;
            algoItemsChosen[9] = true;
            //Debug.Log("Item " + item[9] + " wurde ausgewählt und der Restplatz beträgt: " + maxweight);
        } 
        //Debug.Log("Die errechnete Lösung hat: Value:" + endvalue + " Weight:" + maxweight);
        ausgabe = ausgabe + "\nausgewählt. \nDas Ergebnis hat einen Wert von " + endvalue + " und ein Gewicht von " + (50 - maxweight) + "\n";
        //Vergleich der Lösungen von Spieler und Algorithmus
        int points = 0;
        for(int i = 0; i < 10; i++) {
            if(algoItemsChosen[i])
            for(int j = 0; j < chosenItems.Length; j++) {
                 if(Equals(name[i],chosenItems[j])) {
                    points ++;
                    break;
                }
            }
        }
        points = points * 1000;
        ausgabe = ausgabe + "\nEs wurde ein Punktestand von " + points + " erreicht.";

        return ausgabe;
    }
}
