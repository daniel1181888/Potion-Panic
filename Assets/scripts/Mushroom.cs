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

    public Sprite Image // Implement the Image property
    {
        get
        {
            return _image; // You need to provide a reference to the actual sprite
        }
    }

    private Sprite _image; // Define a private variable to hold the sprite

    private void Start()
    {
        // Assign the sprite you want to use for the mushroom
        _image = GetComponent<SpriteRenderer>().sprite;
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }
}
