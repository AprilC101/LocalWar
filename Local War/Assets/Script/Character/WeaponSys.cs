﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSys : MonoBehaviour {

    private     int         currentWeaponPos;
    private     Camera      playerCam;
    private     GameObject  weaponList;
    private     GameObject  currentWeapon;

    public void AddWeapon()
    {

    }

    public void DropWeapon()
    {

    }

    public void SwitchWeapon()
    {

    }

    public void ShowWeapon()
    {

    }

    // Use this for initialization
    void Start ()
    {
        //Initialize the objects
        playerCam = transform.Find("Main Camera").GetComponent<Camera>();
        weaponList = transform.Find("Weapons").gameObject;

        //Initialize the weapon
        currentWeapon = weaponList.transform.GetChild(0).gameObject;
        currentWeaponPos = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Fire1"))
        {
            //Get the access to the target
            RangeWeapon script = currentWeapon.GetComponent<RangeWeapon>();

            //Set the camera then perform attack
            script.SetCamera(playerCam);
            script.Fire();
        }
    }
}
