using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SemiAuto", menuName = "Weapons/Projectile/SemiAuto")]
public class SemiAutoWeapon : ProjectileWeapon
{
public SemiTrigger specificTrigger;
    public override void Fire()
    {
        Shoot(specificTrigger);
    }
    public override void Initialise(GameObject obj)
    {
      specificTrigger = obj.AddComponent<SemiTrigger>();
        trigger=specificTrigger;
        BaseInitialise(specificTrigger,obj,this);
    }
}
