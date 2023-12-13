using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Text;
public class UIManager : MonoBehaviour
{
    public Player player;
    public GameObject StatusUI;
    public GameObject InventoryUI;
    public GameObject ShopUI;
    private InventoryManager InvenM;
    private StatusManager StatusM;

    public TextMeshProUGUI GoldValue;
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerTitle;
    // Start is called before the first frame update
    void Start()
    {
        InitUI();
        InvenM = InventoryUI.GetComponent<InventoryManager>();
        StatusM = StatusUI.GetComponent<StatusManager>();
    }

    void InitUI()
    {
        StatusUI.SetActive(false);
        InventoryUI.SetActive(false);
        ShopUI.SetActive(false);
        UpdateGold();
        initPlayerName_Title();
    }

    void UpdateGold()
    {
        GoldValue.text = player.Gold.ToString();
    }

    void initPlayerName_Title()
    {
        playerName.text = player.Name;
        playerTitle.text = player.Title;
    }

    // Update is called once per frame


    public void ShowStatusUI()
    {
        StatusUI.SetActive(true);
        StatusM.updateAllstat();
    }

    public void CloseStatusUI()
    {
        StatusUI.SetActive(false);
    }

    public void ShowInvenUI()
    {
        InventoryUI.SetActive(true);
        InvenM.EquipNotion.SetActive(false);
        InvenM.drawSlot();
    }

    public void CloseInvenUI()
    {
        InventoryUI.SetActive(false);
    }
}
