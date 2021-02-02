using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    private InventoryManager inventoryRef;
    public int index;
    private void Start()
    {
        inventoryRef = GameObject.FindWithTag("Player").GetComponent<InventoryManager>(); //The inventory is equal to the Inventory script that attached to the gameObject with the tag "Player"
    }
    private void Update()
    {
        if(transform.childCount == 0) //Check if the inventory slot contains an item or not
        {
            inventoryRef.inventoryIsFull[index] = false; //If not, set the bool isFull to false to indicate that the inventory slot is empty
        }
    }
    public void Drop()
    {
        foreach(Transform childItem in transform)
        {
            childItem.GetComponent<SpawnDroppedItem>().Spawn(); //Get the reference to function Spawn from the script SpawnDroppedItem
            GameObject.Destroy(childItem.gameObject); //Every pickup item is a child of the slot. The foreach loop 
        }
    }
}
