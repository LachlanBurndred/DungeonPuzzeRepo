using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
    // List of items in player inventory.
    public List<GameObject> inventoryList;

    // List of text objects.
    public Text[] inventorySlots;

    // Display text for inventory items.
    public Text invSlot1;
    public Text invSlot2;
    public Text invSlot3;
    public Text invSlot4;
    public Text invSlot5;

    // Canvas which displays items in player inventory.
    public GameObject InventoryCanvas;

    // bool controlling inventory open/close state.
    public bool invOpen = false;

    // Use this for initialization
    void Start()
    {
        // Add text to list.
        inventorySlots[0] = invSlot1;
        inventorySlots[1] = invSlot2;
        inventorySlots[2] = invSlot3;
        inventorySlots[3] = invSlot4;
        inventorySlots[4] = invSlot5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!invOpen)
            {
                OpenInventory();
            }
            else
            {
                CloseInventory();
            }
        }

        for (int i = 0; i < inventoryList.Count; i++)
        {
            inventorySlots[i].text = inventoryList[i].name;
        }
    }

    void addToInventory(GameObject _item)
    {
        inventoryList.Add(_item);
    }

    void OpenInventory()
    {
        invOpen = true;
        InventoryCanvas.SetActive(true);
    }

    void CloseInventory()
    {
        invOpen = false;
        InventoryCanvas.SetActive(false);
    }
}
