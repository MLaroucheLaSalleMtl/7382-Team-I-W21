using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private InventoryManager inventoryRef; //Reference to the Inventory script
    [SerializeField] private GameObject itemButton; //Reference to the item
    // Start is called before the first frame update
    void Start()
    {
        inventoryRef = GameObject.FindWithTag("Player").GetComponent<InventoryManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")) //If the player collides with the items
        {
            for (int i = 0; i < inventoryRef.inventorySlots.Length; i++) //Loop to check the slots in the inventory
            {
                if(inventoryRef.inventoryIsFull[i] == false) //If it is not full => Can stores items
                {
                    inventoryRef.inventoryIsFull[i] = true; //If it is full, stop the loop
                    Instantiate(itemButton, inventoryRef.inventorySlots[i].transform); //Set this item as the first item in the inventory.
                    Destroy(gameObject); //Destroy when collides
                    break;
                }
            }
        }
    }   
}
