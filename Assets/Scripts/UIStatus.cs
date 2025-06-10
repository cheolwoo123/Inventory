
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{

    [SerializeField]
    private Button backButton;
    [SerializeField] 
    private TextMeshProUGUI hpText;
    [SerializeField] 
    private TextMeshProUGUI atkText;
    [SerializeField] 
    private TextMeshProUGUI defText;
    [SerializeField]
    private TextMeshProUGUI critical;

    public void SetCharacterInfo(Character character)
    {
        
        hpText.text = $"{character.hp}";
        atkText.text = $"{character.attack}";
        defText.text = $"{character.defense}";
        critical.text = $"{character.critical}";

    }
    public void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
