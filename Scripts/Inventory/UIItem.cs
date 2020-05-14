using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public Item Item;
    private Image spriteImage;
    private Text countText;
    private UIItem AssociatedHotbarSlot;

    protected void Awake()
    {
        spriteImage = GetComponent<Image>();
        countText = transform.GetComponentInChildren<Text>();
        UpdateItem(null);
    }

    public void UpdateItem(Item item)
    {
        this.Item = item;
        // if the current slot contains an item
        if (this.Item != null)
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = this.Item.Icon;
            countText.text = this.Item.Amount + "";
        }
        // if the current slot contains no item
        else
        {
            spriteImage.color = Color.clear;
            countText.text = "";
        }

        if (AssociatedHotbarSlot != null)
        {
            AssociatedHotbarSlot.UpdateItem(this.Item);
        }
    }

    public void UpdateItem()
    {
        if(this.Item != null)
        {
            this.spriteImage.sprite = this.Item.Icon;
            this.countText.text = this.Item.Amount + "";
        } else
        {
            this.spriteImage.sprite = null;
            this.countText.text = "";
        }
    }

    public void SetHotbarAssociation(UIItem item)
    {
        AssociatedHotbarSlot = item;
    }
}
