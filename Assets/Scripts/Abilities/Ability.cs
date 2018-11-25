using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Ability/New Ability", fileName = "Ability.asset")]
public class Ability : AbilitySO {
    public enum abilityTarget {self, ally, enemy}
    public abilityTarget AbilityTarget;

    public float abilityDamage;
    public float manaPrice;
    public float healthPrice;
    public float cooldown;
    public float levelRequirement;

    public bool isActive;

}
