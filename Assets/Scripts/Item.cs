using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{

    public string name;
    public Sprite icon;

    public void Itme(string _name, Sprite _icon) {

        name = _name;
        icon = _icon;
    }
  
}
