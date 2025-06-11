using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name{ get; private set; }
    public int hp { get; private set; }
    public int attack { get; private set; }
    public int defense{ get; private set; }    
    public int critical { get; private set; }

    public List<Item> Inventory { get; private set; }
    public  Character(string _name, int _hp, int _attack, int _critical,int _defense )
    {
        name = _name;
        hp = _hp;
        attack = _attack;
        defense = _defense;
        critical = _critical;
        Inventory = new List<Item>();
    }
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

  public void Equip()
    {

    }
    public void Unequip()
    {

    }
}
