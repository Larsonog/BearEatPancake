using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatPancake : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start time!");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("munch");
        Destroy(collision.gameObject);
        GameManager.Instance.IncScore(1);
        GetComponent<AudioSource>().Play();
    }

}
