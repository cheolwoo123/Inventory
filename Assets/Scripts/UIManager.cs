using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance{get; private set; }
    


    [SerializeField]
    private UIMainMenu uiMainMenu;
    [SerializeField]
    private UIInventory uiInventory;
    [SerializeField]
    private UIStatus uiStatus;


     

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
       

    }

  public void MainMenu()
    {
        uiMainMenu.gameObject.SetActive(true);
        uiInventory.gameObject.SetActive(false);
        uiStatus.gameObject.SetActive(false);
    }
    public void Inventory()
    {
        uiMainMenu.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(true);
        uiStatus.gameObject.SetActive(false);
    }
    public void Status()
    {
        uiMainMenu.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(false);
        uiStatus.gameObject.SetActive(true);
    }




}
