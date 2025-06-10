
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField]
    private Button statButton;
    [SerializeField] 
    private Button inventoryButton;
    [SerializeField]
    private TextMeshProUGUI characterName;

    public void Start()
    {
        statButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }
    public void CharacterInfo(Character character)
    {
        characterName.text = character.name;
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.OpenMainMenu();
      
    }

    public void OpenInventory()
    {
      UIManager.Instance.OpenInventory();
    }

    public void OpenStatus()
    {
        UIManager.Instance.OpenStatus();
    }
}
