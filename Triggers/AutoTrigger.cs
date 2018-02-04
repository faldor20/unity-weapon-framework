using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTrigger : ProjectileTrigger
{

    public override void DoTrigger()
    {
        if (Input.GetButton("Fire1") && Time.time > specificWeapon.nextfire)
        {
            weapon.Fire();
        }
        else if (Input.GetButton("Fire1") != true && specificWeapon.spread > 0)
        {
            specificWeapon.spread -= (specificWeapon.spreadDecrease * Time.deltaTime);
        }
    }
}
