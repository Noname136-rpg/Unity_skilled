using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<Button> slotList = new List<Button> { };
    public Player player;
    public Sprite Empty;
    public GameObject EquipNotion;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    
    public void drawSlot()
    {
        for (int cnt = 0; cnt < slotList.Count; cnt++)
        {
            if (player.Pinven.Count > cnt)
            {
                slotList[cnt].GetComponent<Image>().sprite = player.Pinven[cnt].itemSprite;
                slotList[cnt].GetComponent<SlotManager>().holdingItem = player.Pinven[cnt];
            }
            else
            {
                slotList[cnt].GetComponent<Image>().sprite = Empty;
            }
        }
    }

    
}
