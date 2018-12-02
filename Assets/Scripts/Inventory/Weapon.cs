using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Items/Weapon", fileName = "Weapon.asset")]
public class Weapon : Item {
    public enum WeaponType {Sword, Axe, Mace}
    public WeaponType weaponType;

    public float damage;

}
