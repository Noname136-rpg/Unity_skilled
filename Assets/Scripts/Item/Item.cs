using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Equipment,
        Consumable
    }
    
    public int itemCode;
    public string itemName;
    public Sprite itemSprite;
    public string itmeTooltip;
    public ItemType itemType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
