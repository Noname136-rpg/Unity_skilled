using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class EquipmentItem : Item
{
    public enum Parts
    {
        Head,
        Body,
        Pants,
        Shoes,
        Hand,
        Weapon
    }
    public enum status
    {
        Attack,
        Defence,
        Health,
        Critical
    }

    public Parts itemPart;
    public status inputStat;
    public int InputValue;
    public bool isEquip = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
