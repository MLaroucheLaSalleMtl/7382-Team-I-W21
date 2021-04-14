using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockGemArena : MonoBehaviour
{
    public EmeraldPickUp ePickUp;

    // Start is called before the first frame update
    void Start()
    {
        ePickUp = GameObject.Find("Hero").GetComponent<EmeraldPickUp>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (ePickUp.emerald == 2)
            {
                ePickUp.SubEmeralds();
                Destroy(gameObject);
            }
        }
    }
}
