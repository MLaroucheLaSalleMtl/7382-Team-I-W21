using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmeraldPickUp : MonoBehaviour
{
    public float emerald = 0;
    public Text emeraldText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Emerald")
        {
            AddEmeralds();
            Destroy(collision.gameObject);
        }
    }

    public void AddEmeralds()
    {
        emerald++;
        emeraldText.text = emerald.ToString();
    }

    public void SubEmeralds()
    {
        emerald -= 2;
        emeraldText.text = emerald.ToString();
    }
}
