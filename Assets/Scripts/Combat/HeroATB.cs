using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroATB : MonoBehaviour {

    public enum ATBStates
    {
        START,
        WAIT,
        TURN,
        CAST,
        ACT
    };

    ATBStates currentState;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Battle");
        currentState = ATBStates.START;
    }


    public float HeroINI;
    private UnitStats unitStats;
    private Equipment unitEquipment;
    public CombatMenu combatMenu;
    public GameObject turnMenu;
   

    void Awake()
    {
        Debug.Log("Getting UnitStats");
        unitStats = GetComponent<UnitStats>();
        unitEquipment = GetComponent<Equipment>();
    }


	// Update is called once per frame
	void Update () {
        Debug.Log(HeroINI);
        switch (currentState)
        {
            case (ATBStates.START):
                Debug.Log("START");
                HeroINI += Time.deltaTime;
                if (HeroINI >= 5f)
                {
                    currentState = ATBStates.TURN;
                }
                break;
            case (ATBStates.TURN):
                //TODO: Työstä valintajärjestelmää
                float totalDamage = this.unitStats.Strength + this.unitEquipment.weapon1.damage;
                Debug.Log(totalDamage);
                Debug.Log("TURN");
                break;

        }

		
	}
}
