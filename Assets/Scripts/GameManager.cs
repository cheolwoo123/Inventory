
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
    playerCharacter = new Character("¹«Á÷", 100,25,15,25);
        UIManager.Instance._uiStatus.SetCharacterInfo(playerCharacter);
        UIManager.Instance._uiMainMenu.CharacterInfo(playerCharacter);
    }

}
