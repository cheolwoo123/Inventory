
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private GameObject slots;
    [SerializeField]
    private Transform slotP;
    GameObject go;
    [SerializeField]
    private List<UISlot> slotList = new List<UISlot>();
    private List<Item> itemList = new List<Item>();
    public void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.OpenMainMenu);
        itemList = GameManager.Instance.playerCharacter.Inventory;
        InitInventoryUI();
    }


    public void InitInventoryUI()
    {

        foreach (Item item in itemList)
        {

            go = Instantiate(slots, slotP);
            go.transform.localPosition = Vector3.zero;
            UISlot slot = go.GetComponent<UISlot>();
            slot.SetItem(item);
            slotList.Add(slot);
        }

        for (int i = 0; i < slotList.Count; i++)
        {
            slotList[i].transform.SetParent(slotP.GetChild(i));
            slotList[i].transform.localPosition = Vector3.zero;
        }


    }




}
