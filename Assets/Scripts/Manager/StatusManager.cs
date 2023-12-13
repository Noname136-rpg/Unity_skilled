using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Text;

public class StatusManager : MonoBehaviour
{
    public Player Splayer;
    public TextMeshProUGUI[] StatusList = new TextMeshProUGUI[] { };


    

    // Start is called before the first frame update
    void Start()
    {
    }
    

    // Update is called once per frame

    public void updateAllstat()
    {
        updateAttack();
        updateDefence();
        updateHealth();
        updateCritical();
    }

    void updateAttack()
    {
        string tempAtk = Splayer.attack.ToString() + "  (+ " + Splayer.AddAtk.ToString() + ")";
        StatusList[(int)EquipmentItem.status.Attack].text = tempAtk;
    }

    void updateDefence()
    {
        string tempDef = Splayer.defence.ToString() + "  (+ " + Splayer.AddDef.ToString() + ")";
        StatusList[(int)EquipmentItem.status.Defence].text = tempDef;
    }

    void updateHealth()
    {
        string tempHel = Splayer.health.ToString() + "  (+ " + Splayer.AddHel.ToString() + ")";
        StatusList[(int)EquipmentItem.status.Health].text = tempHel;
    }

    void updateCritical()
    {
        string tempCri = Splayer.critical.ToString() + "  (+ " + Splayer.AddCri.ToString() + ")";
        StatusList[(int)EquipmentItem.status.Critical].text = tempCri;
    }


}
