using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class JobSO : ScriptableObject {
    public string jobName;
    public string jobDescription;
    public Sprite jobIcon;

}
