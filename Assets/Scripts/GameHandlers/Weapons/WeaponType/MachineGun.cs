using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Weapon
{
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    int enemyMask;

    ParticleSystem gunParticles;
    LineRenderer gunLine;
    Light gunLight;
    float effectsDisplayTime = 0.2f;

    void Start()
    {
        shootableMask = LayerMask.GetMask("Shootable");
        enemyMask = LayerMask.GetMask("Enemy");
        gunParticles = GetComponent<ParticleSystem>();
        gunLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
        gunLight = GetComponent<Light>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeBetweenBullets * effectsDisplayTime)
        {
            DisableEffects();
        }

        if (timer >= timeBetweenBullets)
        {
            isEnableToShoot = true;
        }

    }


    public void DisableEffects()
    {
        gunLine.enabled = false;
        gunLight.enabled = false;
    }


    public override void Shoot()
    {
        if (CanShoot()) {
            isEnableToShoot = false;
            // gunAudio.Play();
            timer = 0f;

            gunLight.enabled = true;


            gunLine.enabled = true;
            gunLine.SetPosition(0, initialBulletPoint.position);

            shootRay.origin = initialBulletPoint.position;
            shootRay.direction = initialBulletPoint.forward;

            if (Physics.Raycast(shootRay, out shootHit, range, shootableMask) || Physics.Raycast(shootRay, out shootHit, range, enemyMask))
            {
                    EnemyHandler enemyHealth = shootHit.collider.GetComponent<EnemyHandler>();
                      if (enemyHealth != null)
                      {
                          enemyHealth.TakeDamage(damagePerShot, shootHit.point);
                      }
                    gunLine.SetPosition(1, shootHit.point);
            }else{
                    gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
            }
        }
       
    }
}
