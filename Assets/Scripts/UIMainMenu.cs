
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
   
    public void OpenMainMenu()
    {
        UIManager.Instance.MainMenu();
      
    }

    public void OpenInventory()
    {
      UIManager.Instance.Inventory();
    }

    public void OpenStatus()
    {
        UIManager.Instance.Status();
    }
}
