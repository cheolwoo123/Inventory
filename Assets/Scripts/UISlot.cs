using UnityEngine.UI;
using UnityEngine;

public class UISlot : MonoBehaviour
{

    [SerializeField] private Image image;

    private Item curentItem;

    public void SetItem(Item item)
    {
        curentItem = item;
        Debug.Log(curentItem.name);
        RefreshUI();
    }
    public void RefreshUI()
    {
        if (curentItem != null)
        {
            image.sprite = curentItem.icon;
            image.color = Color.white;
            
        }
        else
        {
            image.sprite = null;
            image.color = new Color(1, 1, 1, 0);
            
        }
    }




}
