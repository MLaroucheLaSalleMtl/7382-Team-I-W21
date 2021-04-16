using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopManager : MonoBehaviour
{

    [SerializeField] GameObject Shop;
    [SerializeField] Text shopText;
    public PlayerHealth playerH;
    public PickupCoin pCoins;

    //mana
    private float addSpeed = 0.005f;

    //prefabsword
    public GameObject swordPrefab;
    public GameObject spearPrefab;

    //manascript
    public manaBar manaB;

    // Start is called before the first frame update
    void Start()
    {
        playerH = GameObject.Find("Hero").GetComponent<PlayerHealth>();
        pCoins = GameObject.Find("Hero").GetComponent<PickupCoin>();
    }

    // Update is called once per frame
    void Update()
    {
        pCoins.coinUI.text = pCoins.coin.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Shop.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Shop.SetActive(false);
        }
    }

    public void AddHealth()
    {
       

        if(pCoins.coin > 0)
        {
            playerH.heroHealth++;
            pCoins.SubCoins();
        }
        
        Debug.Log("add");
    }

    public void AddMana()
    {
        if(pCoins.coin>=10)
        {
            manaB.mana+= 100;
            pCoins.coin -= 10;
        }
       
    }

    public void AddSword()
    {
        if(pCoins.coin >=30)
        {
            GameObject a = Instantiate(swordPrefab) as GameObject;
            a.transform.position = new Vector2(-19.53f, 1.37f);
            pCoins.coin -= 30;
        }
    }

    public void AddSpear()
    {
        if (pCoins.coin >= 30)
        {
            GameObject a = Instantiate(spearPrefab) as GameObject;
            a.transform.position = new Vector2(-19.53f, 1.37f);
            pCoins.coin -= 30;
        }
    }


}
