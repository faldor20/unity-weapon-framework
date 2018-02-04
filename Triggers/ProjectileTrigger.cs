using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProjectileTrigger : Trigger
{


    public Light muzzelFlash;
    public float flashTime;
    public ProjectileWeapon specificWeapon;
    public override void DoTrigger()
    {

    }
  /*  public void Shoot()
    {
        print("shooting");
        StartCoroutine(ShootFlash());
        float spreadWithVelocity = spread + GetComponentInParent<Rigidbody2D>().velocity.magnitude * SpreadIncreaseFromPlayerVelocity;
        nextfire = Time.time + 1 / fireRate;
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        bullet.transform.Rotate(0, 0, Random.Range(-spread, spread));
        bullet.GetComponent<Rigidbody2D>().velocity = GetComponentInParent<Rigidbody2D>().velocity;
        bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.up * bulletVelocity);
        Destroy(bullet, 5);
        if (spread < maxSpread)
        {
            spread += spreadincrease;
        }

    }
    IEnumerator ShootFlash()
    {
        muzzelFlash.enabled = true;
        yield return new WaitForSeconds(flashTime);
        muzzelFlash.enabled = false;
    }*/
}
