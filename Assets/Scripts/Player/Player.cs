using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Item> Pinven = new List<Item> { };

    public Item test1;
    public Item test2;

    public int attack { get; set; } = 100;
    public int defence { get; set; } = 50;
    public int health { get; set; } = 200;
    public int critical { get; set; } = 50;
    public string Name { get; } = "Kim Ho Young";
    public string Title { get; } = "Beginner";
    public int Gold { get; set; } = 25000;

    public int AddAtk { get; set; } = 0;
    public int AddDef { get; set; } = 0;
    public int AddHel { get; set; } = 0;
    public int AddCri { get; set; } = 0;

    void Start()
    {
        Pinven.Add(test1);
        Pinven.Add(test2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
