using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RubyPickUp : MonoBehaviour
{
    public float ruby= 0;
    public Text rubyText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag=="Ruby")
        {
            AddRubys();
            Destroy(collision.gameObject);
        }
    }

    public void AddRubys()
    {
        ruby++;
        rubyText.text = ruby.ToString();
    }

    public void SubRubys()
    {
        ruby-=3;
        rubyText.text = ruby.ToString();
    }
}
