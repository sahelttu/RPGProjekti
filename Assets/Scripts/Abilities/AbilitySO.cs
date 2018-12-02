using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class AbilitySO : ScriptableObject {
    public string AbilityName;
    public string AbilityDescription;
    public Sprite AbilityIcon;

    public virtual void Cast()
    {

    }


}
