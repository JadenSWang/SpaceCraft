using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIInteractableItem : UIItem, IPointerDownHandler
{
    private UIItem SelectedItem;

    new public void Awake()
    {
        base.Awake();
        SelectedItem = GameObject.Find("SelectedItem").GetComponent<UIItem>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (this.Item != null)
        {
            // if nothing is currently selected
            if(SelectedItem.Item != null)
            {
                Item clone = new Item(SelectedItem.Item);
                SelectedItem.UpdateItem(this.Item);
                UpdateItem(clone);
            } 
            // if there is something in the hand
            else
            {
                // drop off the item
                SelectedItem.UpdateItem(this.Item);
                UpdateItem(null);
            }
        } else if(SelectedItem.Item != null)
        {
            UpdateItem(SelectedItem.Item);
            SelectedItem.UpdateItem(null);
        }
    }
}
