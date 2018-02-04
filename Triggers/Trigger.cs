using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Trigger : MonoBehaviour
{

/*    public float damage;

    public float armorPenitration;
    public float wallPenitration;

    public float fireRate;

    public Sprite sprite;*/
    public Transform shootPoint;
    public Weapon weapon;
    public abstract void DoTrigger();
}