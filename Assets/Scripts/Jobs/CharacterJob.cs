using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Job/New job", fileName = "Job.asset")]
public class CharacterJob : JobSO {

    public int JobLV;
    public int JobEXP;

    //JOB MULTIPLIERIT
    public float JobHP;
    public float JobMP;
    public float JobSTR;
    public float JobVIT;
    public float JobAGI;

    public Ability[] JobAbilities;

}
