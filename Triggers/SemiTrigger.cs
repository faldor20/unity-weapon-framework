using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiTrigger : ProjectileTrigger
{

    public override void DoTrigger()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > specificWeapon.nextfire)
        {
            weapon.Fire();
        }
        else if (!Input.GetButtonDown("Fire1") != true && specificWeapon.spread > 0)
        {
            specificWeapon.spread -= (specificWeapon.spreadDecrease * Time.deltaTime);
        }
    }
}
