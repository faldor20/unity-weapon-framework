using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstTrigger : ProjectileTrigger
{
   /* public float burstRate;
    public int burstSize;*/

    public override void DoTrigger()
    {Debug.Log("trigger");
        print(specificWeapon.nextfire);
        if (/*Input.GetButtonDown("Fire1") &&*/ Time.time > specificWeapon.nextfire)
        {   Debug.Log("fireing from trigger");
            weapon.Fire();
        }
        else if (!Input.GetButtonDown("Fire1") != true && specificWeapon.spread > 0)
        {
            specificWeapon.spread -= (specificWeapon.spreadDecrease * Time.deltaTime);
        }
    }
}
