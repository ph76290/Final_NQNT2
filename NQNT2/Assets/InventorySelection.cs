using UnityEngine;
using System.Collections;

public class InventorySelection : MonoBehaviour {

    public GameObject inventory;
    public GameObject character1;
    public GameObject character2;
    public GameObject craft;
    public GameObject hotbar1;
    public GameObject hotbar2;
    bool inventoryOpen;
    bool characterOpen;
    bool character2Open;
    bool craftOpen;
    // Use this for initialization
    void Start ()
    {
        hotbar1.SetActive(true);
        hotbar2.SetActive(false);
        inventoryOpen = false;
        characterOpen = false;
        craftOpen = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (ChangeCharacter.c)
        {
            hotbar1.SetActive(true);
            hotbar2.SetActive(false);
        }
        else
        {
            hotbar2.SetActive(true);
            hotbar1.SetActive(false);
        }
        if (Input.GetKeyDown("c"))
        {
            if (ChangeCharacter.c)
            {
                if (characterOpen)
                {
                    character1.SetActive(false);
                    characterOpen = false;
                }
                else
                {
                    character1.SetActive(true);
                    characterOpen = true;
                }
            }
            else
            {
                if (characterOpen)
                {
                    character2.SetActive(false);
                    character2Open = false;
                }
                else
                {
                    character2.SetActive(true);
                    character2Open = true;
                }
            }
        }
        if (Input.GetKeyDown("i"))
        {
            if (inventoryOpen)
            {
                inventory.SetActive(false);
                inventoryOpen = false;

            }
            else
            { 
                inventory.SetActive(true);
                inventoryOpen = true;
            }

        }
        if (Input.GetKeyDown("k"))
        {
            if (craftOpen)
            {
                craft.SetActive(false);
                craftOpen = false;
            }
            else
            {
                craft.SetActive(true);
                craftOpen = true;
            }
        }
    }
}
