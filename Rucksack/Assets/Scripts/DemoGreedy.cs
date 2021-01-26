using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoGreedy : MonoBehaviour
{
    public void demo(int[] weight, int[] value, string[] name, GameObject[] objects)
    {
        //Leeren der Textfelder und hinzufügen neuer Texte
        gameObject.GetComponent<PseudocodeText>().clear();
        gameObject.GetComponent<Speechbubble>().clear();
        gameObject.GetComponent<Speechbubble>().addText("Dies ist der Demo-Screen. Mit einem Klick auf den Play-Button beginnt die Demo.");
        
        Time.timeScale = 0f;//Dient zum Anhalten der Demo
        //Hinzufügen der Verzögerung
        StartCoroutine(ExecuteAfterTime(2));
        IEnumerator ExecuteAfterTime(float time)
        {
            //Variablen
            float[] valueperweight = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string itemnames;
            string elsa = "Der Algorithmus generiert die Items und \nberechnet den Wert/Gewicht-Quotienten.";
            string clearing;
            int chosen = 0;
            string ausgabe = "";
            int maxweight = 50;
            int endvalue = 0;
            string final;
            int endweight = 50;

            yield return new WaitForSeconds(time);//Für Verzögerung
            gameObject.GetComponent<Speechbubble>().clear();
            gameObject.GetComponent<Speechbubble>().addText(elsa);

            //Anzeige der erstellten Gegenstände und ihrer Attribute im Pseudocode
            for (int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(time);
                itemnames = "Das Item " + name[i] + " \nmit Gewicht: " + weight[i] + " und\nWert: " + value[i] + " wurde erstellt\n";
                valueperweight[i] = value[i] / weight[i];
                gameObject.GetComponent<PseudocodeText>().addText(itemnames);
            }

            //Anzeige über Leerung des Pseudocode-Fensters
            gameObject.GetComponent<Speechbubble>().clear();
            yield return new WaitForSeconds(time);
            clearing = "Fenster wird in 6 Sekunden geleert.\n";
            gameObject.GetComponent<Speechbubble>().addText(clearing);
            yield return new WaitForSeconds(time);
            clearing = "Fenster wird in 4 Sekunden geleert.\n";
            gameObject.GetComponent<Speechbubble>().addText(clearing);  
            yield return new WaitForSeconds(time);
            clearing = "Fenster wird in 2 Sekunden geleert.\n";
            gameObject.GetComponent<Speechbubble>().addText(clearing);
            yield return new WaitForSeconds(time);
            gameObject.GetComponent<PseudocodeText>().clear();
            gameObject.GetComponent<Speechbubble>().clear();

            //Gegenstand-Wert-Gewicht-Sortierung per Austauschsortierung (Bubblesort/Blasensortierung)
            int sorthelp;
            float floathelp;
            string namehelp;
            GameObject objecthelp;
            for (int i = 9; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (valueperweight[j] < valueperweight[j + 1])
                    {
                        sorthelp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = sorthelp;

                        sorthelp = weight[j];
                        weight[j] = weight[j + 1];
                        weight[j + 1] = sorthelp;

                        floathelp = valueperweight[j];
                        valueperweight[j] = valueperweight[j + 1];
                        valueperweight[j + 1] = floathelp;

                        namehelp = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = namehelp;

                        objecthelp = objects[j];
                        objects[j] = objects[j + 1];
                        objects[j + 1] = objecthelp;
                    }
                }
            }

            //Anzeige Austauschsortierung
            elsa = "Die Items werden durch Bubblesort beginnend mit dem höchsten Wert/Gewicht-Quotienten sortiert";
            gameObject.GetComponent<Speechbubble>().addText(elsa);

            for(int i = 0; i < objects.Length; i++) {
                objects[i].transform.parent = gameObject.GetComponent<ItemDemo>().getSlot(i).transform;
            }
            yield return new WaitForSeconds(time);
            yield return new WaitForSeconds(time);

            //Anzeige Sprechblase Greedyalgorithmus
            gameObject.GetComponent<Speechbubble>().clear();
            elsa = "Der Algortihmus wählt die Items in der sortierten Reihenfolge aus, wenn das Item nicht zu schwer ist.";
            gameObject.GetComponent<Speechbubble>().addText(elsa);

            //Greedyalgorithmusberechnung
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[0]) & value[0] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[0];
                endvalue = endvalue + value[0];
                ausgabe = "Der Gegenstand " + name[0] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[0].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);

            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[1]) & value[1] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[1];
                endvalue = endvalue + value[1];
                ausgabe = "Der Gegenstand " + name[1] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[1].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[2]) & value[2] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[2];
                endvalue = endvalue + value[2];
                ausgabe = "Der Gegenstand " + name[2] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[2].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform; 
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[3]) & value[3] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[3];
                endvalue = endvalue + value[3];
                ausgabe = "Der Gegenstand " + name[3] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[3].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[4]) & value[4] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[4];
                endvalue = endvalue + value[4];
                ausgabe = "Der Gegenstand " + name[4] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[4].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[5]) & value[5] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[5];
                endvalue = endvalue + value[5];
                ausgabe = "Der Gegenstand " + name[5] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[5].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[6]) & value[6] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[6];
                endvalue = endvalue + value[6];
                ausgabe = "Der Gegenstand " + name[6] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[6].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[7]) & value[7] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[7];
                endvalue = endvalue + value[7];
                ausgabe = "Der Gegenstand " + name[7] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[7].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[8]) & value[8] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[8];
                endvalue = endvalue + value[8];
                ausgabe = "Der Gegenstand " + name[8] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[8].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }
            yield return new WaitForSeconds(time);
            if (0 <= (maxweight - weight[9]) & value[9] != 0 & chosen < 7)
            {
                maxweight = maxweight - weight[9];
                endvalue = endvalue + value[9];
                ausgabe = "Der Gegenstand "+name[9] + " wurde ausgewählt\nund in das Nest gelegt.\n\n";
                objects[9].transform.parent = gameObject.GetComponent<ItemDemo>().getNestSlot(chosen).transform;
                chosen++;
                gameObject.GetComponent<PseudocodeText>().addText(ausgabe);
            }

            //Ausgabe Endergebnis
            endweight = 50 - maxweight;
            yield return new WaitForSeconds(time); 
            final = "Der Algorithmus hat eine Lösung\nmit einem Wert von " + endvalue + " \nund einem Gewicht von " + endweight + " berechnet.";
            gameObject.GetComponent<Speechbubble>().clear();
            gameObject.GetComponent<Speechbubble>().addText(final);
            
        }
    }
}
