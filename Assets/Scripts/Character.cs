using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Character
{
    public string name{ get; private set; }
    public int hp { get; private set; }
    public int attack { get; private set; }
    public int defense{ get; private set; }    
    public int critical { get; private set; }
    private int baseAttack;
    private int baseDefense;
    private int baseCritical;
    public List<Item> Inventory { get; private set; }
    public Item EquippedItem { get; private set; }
    public  Character(string _name, int _hp, int _attack, int _critical,int _defense )
    {
        name = _name;
        hp = _hp;

        baseAttack = _attack;
        baseDefense = _defense;
        baseCritical = _critical;

        attack = baseAttack;
        defense = baseDefense;
        critical = baseCritical;
        Inventory = new List<Item>();
    }
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

  public void Equip(Item item)
    {
        EquippedItem = item;
        UpdateStats();
    }
    public void Unequip()
    {
        EquippedItem = null;
        UpdateStats();
    }
    public bool IsEquipped(Item item)
    {
        return EquippedItem == item;
    }

    private void UpdateStats()
    {
        attack = baseAttack + (EquippedItem?.attack ?? 0);
        defense = baseDefense + (EquippedItem?.defense ?? 0);
        critical = baseCritical + (EquippedItem?.critical ?? 0);
    }
}
