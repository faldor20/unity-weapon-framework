using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public abstract class ProjectileWeapon : Weapon {
    public enum Firetype{ Auto, SemiAuto,Burst}
    public Firetype firetype;
    public float bulletVelocity;

	public int ammoCapacity;
    public int defaultMagCount;
    public float maxSpread;
    public float spreadincrease;
    public float spreadDecrease;
    public float SpreadIncreaseFromPlayerVelocity;
    
    public Light muzzelFlash;
    public float flashTime;

    public GameObject bulletPrefab;
    [System.NonSerialized]
        public float spread;
   // public ProjectileTrigger trigger;
    public override void Fire(){
    }
    public override void Initialise(GameObject obj){
    }
    public void BaseInitialise(ProjectileTrigger trigger, GameObject obj,ProjectileWeapon specificWeapon){
        WeaponInitialise(trigger, obj);
        trigger.muzzelFlash = Instantiate(muzzelFlash, obj.transform);
       /* trigger.bulletVelocity = bulletVelocity;
        trigger.ammoCapacity = ammoCapacity;
        trigger.defaultMagCount = defaultMagCount;
        trigger.maxSpread = maxSpread;
        trigger.spreadincrease = spreadincrease;
        trigger.spreadDecrease = spreadDecrease;
        trigger.SpreadIncreaseFromPlayerVelocity = SpreadIncreaseFromPlayerVelocity;
        trigger.flashTime = flashTime;
        trigger.bulletPrefab = bulletPrefab;*/
        trigger.specificWeapon = specificWeapon;
        spread = 0;
        

    }
    public void Shoot(ProjectileTrigger trigger)
    {
        trigger.StartCoroutine(ShootFlash(trigger));
        float spreadWithVelocity = spread + weaponController.GetComponentInParent<Rigidbody2D>().velocity.magnitude * SpreadIncreaseFromPlayerVelocity;
        nextfire = Time.time + 1 / fireRate;
        GameObject bullet = Instantiate(bulletPrefab, trigger.shootPoint.position, trigger.shootPoint.rotation);   
        
        bullet.transform.Rotate(0, 0, Random.Range(-spread, spread));
        bullet.GetComponent<Rigidbody2D>().velocity = weaponController.GetComponentInParent<Rigidbody2D>().velocity+new Vector2(0, bulletVelocity);
        bullet.GetComponent<BulletScript>().damage = damage;
        bullet.GetComponent<BulletScript>().armorPenitration = damage;
        Destroy(bullet, 5);
        NetworkServer.Spawn(bullet);
        if (spread < maxSpread)
        {
            spread += spreadincrease;
        }

    }
    IEnumerator ShootFlash(ProjectileTrigger trigger)
    {
        trigger.muzzelFlash.enabled = true;
        yield return new WaitForSeconds(flashTime);
        trigger.muzzelFlash.enabled = false;
    }
}
