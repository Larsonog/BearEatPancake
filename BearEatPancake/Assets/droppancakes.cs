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
        StartCoroutine("DropPancakeOne");
        StartCoroutine("DropPancakeTwo");
        StartCoroutine("DropPancakeThree");
        //InvokeRepeating("droppancake1", 2f, .56f);
        //InvokeRepeating("droppancake2", 2.5f, .5f);
        //InvokeRepeating("droppancake3", 3f, .75f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator DropPancakeOne()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            Instantiate(pancake1);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
    IEnumerator DropPancakeTwo()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            Instantiate(pancake2);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
    IEnumerator DropPancakeThree()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            Instantiate(pancake3);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }

    void droppancake1()
    {
        Instantiate(pancake1);
    }

    void droppancake2()
    {
        Instantiate(pancake2);
    }

    void droppancake3()
    {
        Instantiate(pancake3);
    }
}
