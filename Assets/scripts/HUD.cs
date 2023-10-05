using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; // You need to include this for Image
using static UnityEngine.UIElements.VisualElement;

public class HUD : MonoBehaviour
{
    public Inventory Inventory; // Make sure you have a reference to your Inventory script here

    private void Start() // Corrected the method name from 'start' to 'Start'
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");

        if (inventoryPanel != null)
        {
            foreach (Transform slot in inventoryPanel)
            {
                if (slot.childCount > 0)
                {
                    Image image = slot.GetComponent<Image>();

                    if (!image.enabled)
                    {
                        image.enabled = true;
                        image.sprite = e.Item.Image;
                        break;
                    }
                }
            }
        }
    }
}
