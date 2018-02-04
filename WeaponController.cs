using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
public Weapon weapon;

    void Start()
    {
        weapon.Initialise(gameObject);
        GetComponent<SpriteRenderer>().sprite = weapon.sprite;
    }

    public void Fire()
    {//print("fired from weaponcontroller");
        weapon.trigger.DoTrigger();
        /* #if UNITY_EDITOR
             weapon.Initialise(gameObject);
         #endif*/
    } 
}
