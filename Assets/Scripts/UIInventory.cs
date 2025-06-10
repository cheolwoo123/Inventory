
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private Button backButton;



    // Start is called before the first frame update
    public void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
