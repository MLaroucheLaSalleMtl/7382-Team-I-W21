using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeObjects : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FadeTo(0.7f, 0.1f));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FadeTo(1f, 0.1f));
        }
    }
    IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = transform.GetComponent<SpriteRenderer>().material.color.a;
        for (float i = 0.0f; i < 1.0f; i+=Time.deltaTime /aTime)
        {
            spriteRenderer.color = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, i));
            transform.GetComponent<SpriteRenderer>().material.color = spriteRenderer.color;
            yield return null;
        }
    }
}
