using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticEnemyDetection
{


    private int Enemies;
    private WeaponInventory weaponInventory;
    private Ray ray;
    private RaycastHit hit;
    private bool rayCastHit;
    public AutomaticEnemyDetection(WeaponInventory weaponInventory) {
        this.weaponInventory = weaponInventory;
        this.Enemies = LayerMask.GetMask("Enemy");
        this.rayCastHit = false;
    }

    private bool CreateRay()
    {
        ray = new Ray(weaponInventory.GetCurrentWeapon().GetInitialBulletPoint().position, 
            weaponInventory.GetCurrentWeapon().GetInitialBulletPoint().forward);
        rayCastHit = Physics.Raycast(ray, out hit, weaponInventory.GetCurrentWeapon().GetRange(), Enemies);

        return rayCastHit;
       
    }

    public bool GetIsLookingAnEnemy()
    {
        return CreateRay();
    }
}
