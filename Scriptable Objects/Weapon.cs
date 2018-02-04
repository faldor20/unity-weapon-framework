using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Weapon : ScriptableObject
{
    public float damage;

    public float armorPenitration;
    public float wallPenitration;

    public float fireRate;
    [System.NonSerialized]
    public float nextfire;

    public Sprite sprite;
    public Transform shootPoint;
    public Trigger trigger;
    public GameObject weaponController;
    public abstract void Fire();
    public abstract void Initialise(GameObject obj);
    public void WeaponInitialise(Trigger trigger,GameObject obj)
    {trigger.weapon = this;
       trigger.shootPoint = Instantiate(shootPoint, obj.transform);
        /*trigger.damage = damage;
        trigger.armorPenitration = armorPenitration;
        trigger.wallPenitration = wallPenitration;
        trigger.fireRate = fireRate;*/
        weaponController = obj;
        nextfire = 0;
    }
}
