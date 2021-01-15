using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNGItemWahl : MonoBehaviour
{
    private int[] rng = new int[10];
    
    public int generateNumber() {
        return Random.Range(1, 30);
        /*System.Random r1 = new System.Random();
        System.Random r2 = new System.Random();
        System.Random r3 = new System.Random();
        System.Random r4 = new System.Random();
        /*
        int z1 = r1.Next(1,31);
        int z2 = r2.Next(1,31);
        int z3 = r3.Next(1,31);
        int z4 = r4.Next(1,31); */

        /*System.DateTime d1 = System.DateTime.Now.Millisecond;
        System.DateTime d2 = System.DateTime.Now.Millisecond;
        System.DateTime d3 = System.DateTime.Now.Millisecond;
        System.DateTime d4 = System.DateTime.Now.Millisecond;
        */
        /*long z1 = System.DateTime.Now.Millisecond + r4.Next();
        for(int i = 0; i < r1.Next(); i++);
        long z2 = System.DateTime.Now.Millisecond + r4.Next();
        for(int i = 0; i < r2.Next(); i++);
        long z3 = System.DateTime.Now.Millisecond + r4.Next();
        for(int i = 0; i < r3.Next(); i++);
        long z4 = System.DateTime.Now.Millisecond + r4.Next();
        
        /*
        Debug.Log("z1: " + z1);
        Debug.Log("z2: " + z2);
        Debug.Log("z3: " + z3);
        Debug.Log("z4: " + z4);
        */

        /*long z5 = ((z1 + z3) * (z2 + z4)) % 29;
        
        if(z5 < 0) {
            z5 = z5 *(-1);
            return z5;
        }
        else {
            return z5;
        }
    */}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space)) {
            for(int i = 0; i < rng.Length; i++) {
                rng[i] = (int)this.generateNumber();
            }

            for(int i = 0; i < rng.Length; i++) {
                Debug.Log("Zufallszahl: " + rng[i]);
            }
        } 

        /*for(int i = 0; i < 100; i++) {
            Debug.Log("Zufallszahl: " + this.generateNumber());
        }*/
    }
}
