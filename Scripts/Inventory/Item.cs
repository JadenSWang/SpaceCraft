using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int Id;
    public string Title;
    public string Description;
    public int Amount;
    public int MaxStack;
    
    public Sprite Icon;
    public Dictionary<string, int> Stats = new Dictionary<string, int>();

    public Item(int id, string title, string description, int amount, int maxStack, Dictionary<string, int> stats)
    {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Amount = amount;
        this.MaxStack = maxStack;
        this.Icon = Resources.Load<Sprite>("Sprites/Items/" + title);
        this.Stats = stats;
    }

    public Item(int id, string title, string description, int maxStack, Dictionary<string, int> stats) : this(id, title, description, 1, maxStack, stats) { }

    public Item(Item item) : this(item.Id, item.Title, item.Description, item.Amount, item.MaxStack, item.Stats) { }

    public bool Equals(Item other)
    {
        return (other.Title == this.Title) && (other.Id == this.Id);
    }
}
