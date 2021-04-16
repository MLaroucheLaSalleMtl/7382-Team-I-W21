using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidequest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
        //if(collision.CompareTag("Sword"))
        //{
            //Debug.Log("Test");
            //Destroy(gameObject);
        //}
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag==("Sword"))
        {
            Debug.Log("Test");
            //Destroy(gameObject);
        }
    }
}
