using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockArena : MonoBehaviour
{
    public RubyPickUp rPickUp;

    // Start is called before the first frame update
    void Start()
    {
        rPickUp = GameObject.Find("Hero").GetComponent<RubyPickUp>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           if(rPickUp.ruby == 3)
            {
                rPickUp.SubRubys();
                Destroy(gameObject);
            }
        }
    }

}
