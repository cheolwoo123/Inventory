using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private UIMainMenu uiMainMenu;
    private UIInventory uiInventory;
    private UIStatus uiStatus;

    public void OpenMainMenu()
    {
        uiMainMenu.gameObject.SetActive(true);
        uiInventory.gameObject.SetActive(false);
        uiStatus.gameObject.SetActive(false);

    }
    
    public void OpenInventory()
    {
        uiMainMenu.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(true);
        uiStatus.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        uiMainMenu.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(false);
        uiStatus.gameObject.SetActive(true);
    }

}
