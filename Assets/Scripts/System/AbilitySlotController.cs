using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySlotController : MonoBehaviour {

    public Ability ability;

    private void Start()
    {
        UpdateInfo();
    }

    public void UpdateInfo()
    {
        Image displayImage = transform.Find("Image").GetComponent<Image>();


        if (ability)
        {
            displayImage.sprite = ability.AbilityIcon;
        }
        else
        {
            displayImage.sprite = null;
        }
    }

    public void CastAbility()
    {
        if (ability)
        {
            Debug.Log("You clicked the ability " + ability.AbilityName);
        }else
        {
            Debug.Log("ERROR: No ability assigned to this slot.");
        }
    }

}
