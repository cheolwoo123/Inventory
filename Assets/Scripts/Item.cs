
using UnityEngine;

[System.Serializable]
public class Item 
{

    public string name { get; private set; }
    public Sprite icon { get; private set; }
    public int attack { get; private set; }
    public int defense { get; private set; }
    public int critical { get; private set; }
    public int hp { get; private set; }
    public Item(string _name, Sprite _icon, int _attack = 0, int _defense = 0, int _critical = 0, int _hp = 0)
    {
        name = _name;
        icon = _icon;
        attack = _attack;
        defense =_defense;
        critical = _critical;
    }
    
  
}
