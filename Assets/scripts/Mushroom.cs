using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return "Mushroom";
        }
    }

    public Sprite _Image;

    public Sprite Image // Implement the Image property
    {
        get
        {
             return _Image; // You need to provide a reference to the actual sprite
        }
    }

    

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }
}
