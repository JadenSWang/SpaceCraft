using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> Items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return new Item(Items.Find(item => item.Id == id));
    }

    public Item GetItem(string itemName)
    {
        return new Item(Items.Find(item => item.Title == itemName));
    }

    private void BuildDatabase()
    {
        Items = new List<Item>() {
            new Item(0, "Titanium", "An extremely durable and lightweight item, great for use in combat scenarios", 1000, new Dictionary<string, int>
            {
                {"Weight", 5}
            }),
            new Item(1, "Diamond", "A rare gem for sure!", 1000, new Dictionary<string, int>
            {
                {"Weight", 2}
            }),
        };
    }
}
