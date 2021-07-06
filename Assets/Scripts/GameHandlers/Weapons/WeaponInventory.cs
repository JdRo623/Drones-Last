using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventory : MonoBehaviour
{
    public Weapon[] weapons;

    private Weapon currentWeapon;

    void Awake()
    {
        if (weapons.Length != 0)     
        currentWeapon = weapons[0];
    }

    public Weapon GetCurrentWeapon() {
        return currentWeapon;
    }
    public void InterchangeWeapon()
    {
        return;
    }

    public void ChangeWeapon(Weapon newWeapon)
    {
        return;
    }


}
