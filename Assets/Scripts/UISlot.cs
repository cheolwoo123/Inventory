using UnityEngine.UI;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{

    [SerializeField] private Image image;
    [SerializeField] private Text equippedText;
    private Item curentItem;
    private Character character;
    public void SetItem(Item item)
    {
        curentItem = item;
        character = GameManager.Instance.playerCharacter;
        RefreshUI();
    }
    public void RefreshUI()
    {
        if (curentItem != null)
        {
            image.sprite = curentItem.icon;
            image.color = Color.white;
            equippedText.text = character.IsEquipped(curentItem) ? "E" : "";
        }
        else
        {
            image.sprite = null;
            image.color = new Color(1, 1, 1, 0);
            
        }
    }

    public void OnClickSlot()
    {
        Debug.Log("Å¬¸¯µÊ");
        if (character.IsEquipped(curentItem))
            character.Unequip();
        
        else
            character.Equip(curentItem);
        Debug.Log("Å¬¸¯µÊ");
        UIManager.Instance._uiInventory.RefreshAllSlots();             
        UIManager.Instance._uiStatus.SetCharacterInfo(character);      
    }




}
