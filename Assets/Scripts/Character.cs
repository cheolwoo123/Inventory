using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string name;
    public int hp;
    public int attack;
    public int critical;
    public int defense;

    public  Character(string _name, int _hp, int _attack, int _critical,int _defense )
    {
        name = _name;
        hp = _hp;
        attack = _attack;
        critical = _critical;
        defense = _defense;

    }

}
