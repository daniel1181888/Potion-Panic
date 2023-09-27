using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // You need to include this for Image

public class HUD : MonoBehaviour
{
    public Inventory Inventory; // Make sure you have a reference to your Inventory script here

    private void Start() // Corrected the method name from 'start' to 'Start'
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e) // Corrected the parameter type
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel)
        {
            Image image = slot.GetChild(0).GetComponent<Image>(); // Corrected the syntax for 'GetChild' and 'GetComponent'

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }
        }
    }
}
