using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIInventory : MonoBehaviour
{
    public List<UIInteractableItem> UIItems = new List<UIInteractableItem>();
    public GameObject SlotPrefab;
    public GameObject InteractableSlotPrefab;
    public Transform SlotPanel;
    public Transform HotBarPanel;
    public int NumSlots = 30;
    public int HotBarNumSlots = 10;

    public Transform QuickAccessPanel;

    private void Awake()
    {
        for(int i = 0; i < NumSlots; i++)
        {
            GameObject instance = Instantiate(InteractableSlotPrefab);
            instance.transform.SetParent(SlotPanel, false);
            UIItems.Add(instance.GetComponentInChildren<UIInteractableItem>());
        }

        for(int i = 0; i < HotBarNumSlots; i++)
        {
            GameObject instance = Instantiate(InteractableSlotPrefab);
            instance.transform.SetParent(HotBarPanel, false);
            UIInteractableItem uiComponent = instance.GetComponentInChildren<UIInteractableItem>();
            UIItems.Add(uiComponent);

            GameObject quickAccessInstance = Instantiate(SlotPrefab);
            quickAccessInstance.transform.SetParent(QuickAccessPanel, false);
            UIItem associatedHotbarSlot = quickAccessInstance.GetComponentInChildren<UIItem>();
            uiComponent.SetHotbarAssociation(associatedHotbarSlot);
        }
    }

    public void UpdateSlot(int slot, Item item)
    {
        UIItems[slot].UpdateItem(item);
    }

    public void UpdateSlot(Item toUpdate)
    {
        // finds the UIItem holding the item to update and updates it
        Debug.Log(UIItems.Find(item => item.Item == toUpdate));
        UIItems.Find(item => item.Item == toUpdate).UpdateItem();
    }

    public int AddNewItem(Item item)
    {
        // Searches for an empty slot
        int index = UIItems.FindIndex(i => i.Item == null);
        if (index != -1)
        {
            UpdateSlot(index, item);
        }

        return index;
    }

    public void RemoveItem(Item item)
    {
        UpdateSlot(UIItems.FindIndex(i => i.Item == item), null);
    }
}
