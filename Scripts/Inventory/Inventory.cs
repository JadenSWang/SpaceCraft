using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> CharacterItems = new List<Item>();
    public ItemDatabase ItemDatabase;
    public UIInventory InventoryUI;
    public GameObject InventoryPanel;

    private void Start()
    {
        GiveItem(0);
        GiveItem("Titanium", 1999);
        GiveItem("Diamond", 100);

        InventoryPanel.SetActive(false);
        GameControls test = new GameControls();
        test.GameControl.SpawnStation.performed += _ =>
        {
            Debug.Log("Giving Item");
            GiveItem(0, 700);
        };
        test.GameControl.SpawnShip.performed += _ =>
        {
            Debug.Log("Giving Diamond");
            GiveItem(1, 800);
        };
        test.Enable();
    }

    private void Update()
    {
    }

    public void GiveItem(int id)
    {
        GiveItem(id, 1);
    }

    public void GiveItem(string itemName)
    {
        GiveItem(itemName, 1);
    }

    public void GiveItem(int id, int numItems)
    {
        GiveItem(ItemDatabase.GetItem(id), numItems);
    }

    public void GiveItem(string itemName, int numItems)
    {
        GiveItem(ItemDatabase.GetItem(itemName), numItems);
    }

    private bool GiveItem(Item toAdd, int numItems)
    {
        if (toAdd == null) { return false; }

        for (int i = 0; i < numItems; i++)
        {
            Item currentItem = CharacterItems.Find(item => item.Equals(toAdd) && item.Amount < item.MaxStack);
            // if this item does not exist in my inventory
            if(currentItem == null)
            {
                int slotNumber = InventoryUI.AddNewItem(toAdd);
                if (slotNumber == -1) { return false; }
                CharacterItems.Add(toAdd);
            }
            else
            {
                currentItem.Amount++;
                InventoryUI.UpdateSlot(currentItem);
            }
        }

        return true;
    }

    public Item CheckForItem(int id)
    {
        return CharacterItems.Find(item => item.Id == id);
    }

    public void RemoveItem(int id)
    {
        Item item = CheckForItem(id);
        if(item != null)
        {
            CharacterItems.Remove(item);
            InventoryUI.RemoveItem(item);
        }
    }
}
