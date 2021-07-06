using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon: MonoBehaviour
{
    public enum WeaponState
    {
        Deactivated,
        Activated,
        NotPicked
    }
    public enum AmmoType
    {
        Finite,
        Infinite,
    }

    public WeaponScriptableObject weaponScriptableObject;
    protected float range;
    protected float ammo;
    protected int damagePerShot;
    protected float timeBetweenBullets;
    public GameObject graphic;
    protected AudioSource gunAudio;
    private WeaponState state;
    private AmmoType ammoType;
    protected float timer;
    protected bool isEnableToShoot;
    public Transform initialBulletPoint;
    void Awake()
    {
        range = weaponScriptableObject.Range;
        ammo = weaponScriptableObject.Ammo;
        damagePerShot = weaponScriptableObject.DamagePerShot;
        timeBetweenBullets = weaponScriptableObject.TimeBetweenBullets;
        ammoType = weaponScriptableObject.AmmoType;
        isEnableToShoot = true;
        //graphic = weaponScriptableObject.Graphic;
    }
    public abstract void Shoot();

    public void ThrowWeapon() {
        state = WeaponState.NotPicked;
        graphic.SetActive(false);
    }

    public void DeactivateWeapon() {
        state = WeaponState.Deactivated;
        graphic.SetActive(false);
    }

    public void ActivateWeapon() {
        state = WeaponState.Activated;
        graphic.SetActive(true);
    }

    public WeaponState GetState() {
        return state;
    }
    public float GetRange()
    {
        return range;
    }
    public Transform GetInitialBulletPoint()
    {
        return initialBulletPoint;
    }

    public bool CanShoot() {
        return isEnableToShoot;
    }
    public AmmoType GetAmmoType()
    {
        return ammoType;
    }



}
