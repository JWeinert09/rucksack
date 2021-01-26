using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbungGreedy : MonoBehaviour
{
     public string greedy(int[] weight, int[] value, string[] name, string[] chosenItems) {
        float[] valueperweight = new float[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        //Berechnung des Wert-Gewichts-Quotienten
        for (int i = 0; i < 10; i++)
        {
            valueperweight[i] = value[i] / weight[i];
        }

        //Gegenstands-Wert-Gewichts-Austauschsortierung (Bubblesort/Blasensortierung)
        float perHelp;
        int sorthelp;
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

        //Greedyalgorithmusberechnung
        int anzahl = 0;
        int chosen = 0;
        string ausgabe = "Vom Algorithmus wurden \n\n";
        int maxweight = 50;
        int endvalue = 0;
        bool[] algoItemsChosen = new bool[10];
        if (0 <= (maxweight - weight[0]) & value[0] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[0];
            endvalue = endvalue + value[0];
            ausgabe = ausgabe + name[0] + "\n";
            chosen++;
            algoItemsChosen[0] = true;
        } 
        if (0 <= (maxweight - weight[1]) & value[1] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[1];
            endvalue = endvalue + value[1];
            ausgabe = ausgabe + name[1] + "\n";
            chosen++;
            algoItemsChosen[1] = true;
        }
        if (0 <= (maxweight - weight[2]) & value[2] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[2];
            endvalue = endvalue + value[2];
            ausgabe = ausgabe + name[2] + "\n";
            chosen++;
            algoItemsChosen[2] = true;
        }
        if (0 <= (maxweight - weight[3]) & value[3] != 0 & chosen < 7)  
        {
            maxweight = maxweight - weight[3];
            endvalue = endvalue + value[3];
            ausgabe = ausgabe + name[3] + "\n";
            chosen++;
            algoItemsChosen[3] = true;
        }
        if (0 <= (maxweight - weight[4]) & value[4] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[4];
            endvalue = endvalue + value[4];
            ausgabe = ausgabe + name[4] + "\n";
            chosen++;
            algoItemsChosen[4] = true;
        }
        if (0 <= (maxweight - weight[5]) & value[5] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[5];
            endvalue = endvalue + value[5];
            ausgabe = ausgabe + name[5] + "\n";
            chosen++;
            algoItemsChosen[5] = true;
        }
        if (0 <= (maxweight - weight[6]) & value[6] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[6];
            endvalue = endvalue + value[6];
            ausgabe = ausgabe + name[6] + "\n";
            chosen++;
            algoItemsChosen[6] = true;
        }
        if (0 <= (maxweight - weight[7]) & value[7] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[7];
            endvalue = endvalue + value[7];
            ausgabe = ausgabe + name[7] + "\n";
            chosen++;
            algoItemsChosen[7] = true;
        }
        if (0 <= (maxweight - weight[8]) & value[8] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[8];
            endvalue = endvalue + value[8];
            ausgabe = ausgabe + name[8] + "\n";
            chosen++;
            algoItemsChosen[8] = true;
        }
        if (0 <= (maxweight - weight[9]) & value[9] != 0 & chosen < 7)
        {
            maxweight = maxweight - weight[9];
            endvalue = endvalue + value[9];
            ausgabe = ausgabe + name[9] + "\n";
            chosen++;
            algoItemsChosen[9] = true;
        } 
        ausgabe = ausgabe + "\nausgewählt. \nDas Ergebnis hat einen Wert von " + endvalue + " und ein Gewicht von " + (50 - maxweight) + "\n";
        //Vergleich der Lösungen von Spieler und Algorithmus mit Punkteberechnung
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
