using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Text;

public class SlotManager: MonoBehaviour
{
    public Item holdingItem;
    public EquipManager EquipM;
    public GameObject EquipNotion;
    public GameObject isEquip;
    // Start is called before the first frame update

    private void Start()
    {
        isEquip.SetActive(false);
    }

    public void ShowEquipNotion()
    {
        EquipNotion.SetActive(true);
        EquipM.drawEquipNotion(holdingItem, gameObject.GetComponent<SlotManager>());
    }

    public void ActiveEquip()
    {
        isEquip.SetActive(true);
    }
}
