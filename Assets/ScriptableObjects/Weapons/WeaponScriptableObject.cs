using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class WeaponScriptableObject : ScriptableObject
{
    public float Range;
    public float Ammo;
    public int DamagePerShot;
    public float TimeBetweenBullets;
    public GameObject Graphic;
    public Weapon.AmmoType AmmoType;
}
