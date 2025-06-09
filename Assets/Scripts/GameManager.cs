
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
    public Character playerCharacter;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
           
            Destroy(gameObject);
            return;
        }
                     
        Instance = this;
        DontDestroyOnLoad(this);

    playerCharacter = new Character("¹«Á÷", 50,30,100,25);

    }


}
