using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogM : MonoBehaviour
{
    [SerializeField] GameObject dialogB;
    [SerializeField] Text dialogT;
    [SerializeField] int letterS;
    public bool DialogActive;
    
    

    void Start()
    {
        Dialog();
    }

    void Update()
    {
             
    }

    public void Dialog()
    {

        dialogB.SetActive(false);
        StartCoroutine(TypeDialog(dialogT.text));
    }

    public IEnumerator TypeDialog(string dialog)
    {
        dialogT.text = "";
        foreach (var letter in dialog.ToCharArray())
        {
            dialogT.text += letter;
            yield return new WaitForSeconds(1f / letterS);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            dialogB.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogB.SetActive(false);
        }
    }

    public void ShowDialog()
    {

    }
}
