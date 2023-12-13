using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Text;

public class EquipManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI IName;
    public TextMeshProUGUI ITooltip;
    public Text whichStatus;
    public Text StatusValue;

    public List<Sprite> StatusSpriteList;
    public List<string> StatusStringList = new List<string> { "Attack", "Defence", "Health", "Critical" };

    static Color32 AttackColor = new Color32(194, 0, 0, 255);
    static Color32 DefenceColor = new Color32(0, 109, 194, 255);
    static Color32 HealthColor = new Color32(17, 194, 0, 255);
    static Color32 CriticalColor = new Color32(185, 93, 0, 255);
    public List<Color32> StatusColorList;
    
    public Image ItemSprite;
    public Image StatusSprite;

    public GameObject TInvenM;
    private InventoryManager InvenM;
    void Start()
    {
        StatusColorList = new List<Color32> { AttackColor, DefenceColor, HealthColor, CriticalColor };
        //InvenM = TInvenM.GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    public void drawEquipNotion(Item item)
    {
        IName.text = item.itemName;
        ITooltip.text = item.itmeTooltip;
        Debug.Log((int)((item as EquipmentItem).inputStat));

        whichStatus.text = StatusStringList[(int)((item as EquipmentItem).inputStat)];
        whichStatus.color = StatusColorList[(int)((item as EquipmentItem).inputStat)];
        //whichStatus.color = new Color32(17, 194, 0, 255); 

        StatusValue.text = (item as EquipmentItem).InputValue.ToString();
        StatusValue.color = StatusColorList[(int)((item as EquipmentItem).inputStat)];
        //StatusValue.color = new Color32(17, 194, 0, 255);

        ItemSprite.sprite = item.itemSprite;
        StatusSprite.sprite = StatusSpriteList[(int)((item as EquipmentItem).inputStat)];
    }

    public void ConfirmEquip()
    {

    }

    public void CancelEquip()
    {
        gameObject.SetActive(false);
    }
}
