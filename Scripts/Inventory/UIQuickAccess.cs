using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIQuickAccess : MonoBehaviour
{
    public List<UIInteractableItem> QuickAccessItems;
    public GameObject QuickAccessSlotPrefab;
    public Transform QuickAccessPanel;
    public int QuickAccessNumSlots = 9;

    public void Awake()
    {
        for (int i = 0; i < QuickAccessNumSlots; i++)
        {
            GameObject instance = Instantiate(QuickAccessSlotPrefab);
            instance.transform.SetParent(QuickAccessPanel, false);
            QuickAccessItems.Add(instance.GetComponentInChildren<UIInteractableItem>());
        }
    }

    public void UpdateSlot(int slot, Item item)
    {
        QuickAccessItems[slot].UpdateItem(item);
    }
}
