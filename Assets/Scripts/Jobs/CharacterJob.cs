using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Job/New Job", fileName = "Job.asset")]
public class CharacterJob : JobSO {

    public float HealthMaxMultip;
    public float ManaMaxMultip;
    public float StrengthMultip;
    public float VitalityMultip;
    public float AgilityMultip;

    public Ability[] JobAbilities;

}
