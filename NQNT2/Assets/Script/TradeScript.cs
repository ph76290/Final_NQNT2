using UnityEngine;
using System.Collections;

public class TradeScript : MonoBehaviour {

    public Inventory _inventory;
    public GameObject storage;
    private bool showGUI = false;
    private PlayerControl playercontrol;
	// Use this for initialization
	void Start ()
    {
        playercontrol = GameObject.Find("Health").GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = true;
        }
    }
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            showGUI = false;
        }
    }
    void OnGUI()
    {
        if (showGUI)
        {
            GUI.BeginGroup(new Rect(Screen.width / 2 - 550, Screen.height / 2 - 350, 800, 550));
            GUI.Box(new Rect(0, 0, 400, 550), "SHOP");
            GUI.Label(new Rect(10, 20, 320, 300), "Hello i'm a merchant i sell a lot of differents things !");
            if (GUI.Button(new Rect(5, 60, 300, 30), "HP potion (+10hp) - 5 gold"))
            {
                if (PlayerInventory.currentMoney >= 5)
                {
                    _inventory.addItemToInventory(10);
                    PlayerInventory.currentMoney -= 5;
                }
            }
            if (GUI.Button(new Rect(5, 100, 300, 30), "Mana potion (+10mana) - 5 gold"))
            {
                if (PlayerInventory.currentMoney >= 5)
                {
                    _inventory.addItemToInventory(11);
                    PlayerInventory.currentMoney -= 5;
                }
            }
            if (GUI.Button(new Rect(5, 140, 300, 30), "Leather chest (+10hp ; +10armor) - 35 gold"))
            {
                if (PlayerInventory.currentMoney >= 35)
                {
                    _inventory.addItemToInventory(3);
                    PlayerInventory.currentMoney -= 35;
                }
            }
            if (GUI.Button(new Rect(5, 180, 300, 30), "Leather helmet (+10hp ; +10armor) - 35 gold"))
            {
                if (PlayerInventory.currentMoney >= 35)
                {
                    _inventory.addItemToInventory(1);
                    PlayerInventory.currentMoney -= 35;
                }
            }
            if (GUI.Button(new Rect(5, 220, 300, 30), "Leather shoes (+10hp ; +10armor) - 35 gold"))
            {
                if (PlayerInventory.currentMoney >= 35)
                {
                    _inventory.addItemToInventory(7);
                    PlayerInventory.currentMoney -= 35;
                }
            }
            if (GUI.Button(new Rect(5, 260, 300, 30), "Raw meat (+5hp) - 5 gold"))
            {
                if (PlayerInventory.currentMoney >= 5)
                {
                    _inventory.addItemToInventory(14);
                    PlayerInventory.currentMoney -= 5;
                }
            }
        }
    }
}
