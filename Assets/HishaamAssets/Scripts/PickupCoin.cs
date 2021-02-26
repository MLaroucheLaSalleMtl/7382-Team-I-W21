using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCoin : MonoBehaviour
{
    [SerializeField]private float coin = 0;
    public Text coinUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag=="Coin")
        {
            AddCoins();
            Destroy(collision.gameObject);
        }
    }

    void AddCoins()
    {
        coin++;
        coinUI.text = coin.ToString();
    }

}
