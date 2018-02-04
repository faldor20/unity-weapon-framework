using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Auto", menuName = "Weapons/Projectile/Auto")]
public class AutoWeapon : ProjectileWeapon
{

   public AutoTrigger specificTrigger;
    public override void Fire()
    {
        Shoot(specificTrigger);
    }
    public override void Initialise(GameObject obj)
    {
         specificTrigger = obj.AddComponent<AutoTrigger>();
        trigger=specificTrigger;
        BaseInitialise(specificTrigger,obj,this);

    }

}
