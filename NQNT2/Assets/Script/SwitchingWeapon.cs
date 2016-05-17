using UnityEngine;
using System.Collections;

public class SwitchingWeapon : MonoBehaviour {

    public int currentWeapon = 0;
    public int maxWeapon = 2;
	// Use this for initialization
	void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currentWeapon + 1 <= maxWeapon)
            {
                currentWeapon++;
            }
            else
            {
                currentWeapon = 0;
            }
            selectWeapon(currentWeapon);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentWeapon - 1 >= 0)
            {
                currentWeapon--;
            }
            else
            {
                currentWeapon = maxWeapon;
            }
            selectWeapon(currentWeapon);
        }
        if (currentWeapon == maxWeapon + 1)
        {
            currentWeapon = 0;
        }
        if (currentWeapon == -1)
        {
            currentWeapon = maxWeapon;
        }
        if (Input.GetKeyDown("1"))
        {
            currentWeapon = 0;
            selectWeapon(currentWeapon);
        }
        if (Input.GetKeyDown("2"))
        {
            currentWeapon = 1;
            selectWeapon(currentWeapon);
        }
        if (Input.GetKeyDown("3"))
        {
            currentWeapon = 2;
            selectWeapon(currentWeapon);
        }
    }
    void awake()
    {
        selectWeapon(0);
    }
    void selectWeapon(int index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == index)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
