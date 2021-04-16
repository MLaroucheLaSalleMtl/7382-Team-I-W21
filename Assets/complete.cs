using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complete : MonoBehaviour
{
    [SerializeField] private UI_Victory victoryUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            victoryUI.DisplayUI();
        }
    }
}
