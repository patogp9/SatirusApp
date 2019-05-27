using System;

public class Item
{
    string itemName;

    string itemDescr;

    public string ItemName
    {
        get
        {
            return itemName;
        }

        set
        {
            itemName = value;
        }
    }

    public string ItemDescr
    {
        get
        {
            return itemDescr;
        }

        set
        {
            itemDescr = value;
        }
    }

    public Item(string name, string descr)
	{
        this.itemName = name;
        this.ItemDescr = descr;
	}
}
