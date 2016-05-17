using UnityEngine;
using System.Collections;

public class InventorySelection : MonoBehaviour {

    public GameObject inventory;
    public GameObject character;
    public GameObject craft;
    bool inventoryOpen;
    bool characterOpen;
    bool craftOpen;
    // Use this for initialization
    void Start ()
    {
        inventoryOpen = false;
        characterOpen = false;
        craftOpen = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
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
        if (Input.GetKeyDown("c"))
        {
            if (characterOpen)
            {
                character.SetActive(false);
                characterOpen = false;
            }
            else
            {
                character.SetActive(true);
                characterOpen = true;
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
