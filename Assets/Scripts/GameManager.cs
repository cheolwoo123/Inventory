
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    [SerializeField]
    public Character playerCharacter{get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
           
            Destroy(gameObject);
            return;
        }
                     
        Instance = this;
        DontDestroyOnLoad(this);
        SetData();

    }
    public void SetData()
    {
    playerCharacter = new Character("무직", 100,25,15,25);

        
        Sprite swordIcon = Resources.Load<Sprite>("Image/Sword");
        Item sword = new Item("강철 검", swordIcon); 

        Sprite defenseIcon = Resources.Load<Sprite>("Image/Defense");
        Item defense = new Item("방패", defenseIcon);  


       
        playerCharacter.AddItem(sword);
        playerCharacter.AddItem(defense);
        UIManager.Instance._uiStatus.SetCharacterInfo(playerCharacter);
        UIManager.Instance._uiMainMenu.CharacterInfo(playerCharacter);

        for (int i = 0; i < playerCharacter.Inventory.Count; i++)
        {
                    
        }
    }

}
