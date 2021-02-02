using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppancakes : MonoBehaviour
{
    public GameObject pancake1;
    public GameObject pancake2;
    public GameObject pancake3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("droppancake1", 2f, .56f);
        InvokeRepeating("droppancake2", 2.5f, .5f);
        InvokeRepeating("droppancake3", 3f, .75f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void droppancake1() { 
        Instantiate(pancake1); }

    void droppancake2() { 
        Instantiate(pancake2); }

    void droppancake3() { 
        Instantiate(pancake3); }
}
