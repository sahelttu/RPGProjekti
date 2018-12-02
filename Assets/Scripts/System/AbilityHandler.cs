using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHandler : MonoBehaviour {

    public List<Ability> activeBar = new List<Ability>();
    public GameObject player;
    public GameObject abilityPanel;
    public UnitStats playerStats;

    void UpdatePanelSlots()
    {
        int index = 0;

        foreach(Transform child in abilityPanel.transform)
        {
            AbilitySlotController slot = child.GetComponent<AbilitySlotController>();
            if (index < activeBar.Count)
            {
                slot.ability = activeBar[index];
            }
            else
            {
                slot.ability = null;
            }
            slot.UpdateInfo();
            index++;
        }
    }

    void ReplacePanelSlots()
    {
        activeBar = playerStats.AbilityBar;
        UpdatePanelSlots();
    }

    void Awake()
    {
        playerStats = player.GetComponent<UnitStats>();
    }

    // Use this for initialization
    void Start () {
        ReplacePanelSlots();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
