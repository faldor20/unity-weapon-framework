using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Burst", menuName = "Weapons/Projectile/Burst")]
public class BurstWeapon : ProjectileWeapon
{
    public float burstRate;
    public int burstSize;
    public BurstTrigger specificTrigger;
    private bool isBursting;
    public override void Fire()
    {
      //  Debug.Log("fireing from weapon");
        trigger.StartCoroutine(BurstShoot());
    }
    public override void Initialise(GameObject obj)
    {   specificTrigger = obj.AddComponent<BurstTrigger>();
        trigger = specificTrigger;
        BaseInitialise(specificTrigger,obj,this);
       /* specificTrigger.burstRate = burstRate;
        specificTrigger.burstSize = burstSize;*/
    }
        IEnumerator BurstShoot()
    {

       // Debug.Log("burst started");
        isBursting = true;
        for (int i = 0; i < burstSize; i++)
        {
            float bulletDelay = 1 / burstRate;
            Shoot(specificTrigger);
            yield return new WaitForSeconds(bulletDelay); // waits for the value of bulletDelay before repeating the for loop
        }
        isBursting = false;
    }

}
