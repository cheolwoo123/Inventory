
using UnityEngine;

[System.Serializable]
public class Item 
{

    public string name { get; private set; }
    public Sprite icon { get; private set; }

    public Item(string _name, Sprite _icon)
    {
        name = _name;
        icon = _icon;
    }
    
  
}
