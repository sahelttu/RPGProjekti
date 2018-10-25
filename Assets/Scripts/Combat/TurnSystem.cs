using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour {

    private List<UnitStats> unitList;

    [SerializeField]
    private GameObject turnMenu, enemyUnitsMenu;

	// Use this for initialization
	void Start () {
        /*unitList = new List<UnitStats>();
        GameObject[] playerUnits = GameObject.FindGameObjectsWithTag("PlayerUnit");
        //Player Units
        foreach(GameObject playerUnit in playerUnits)
        {
            UnitStats currentUnitStats = playerUnit.GetComponent<UnitStats>();
            currentUnitStats.calculateNextActTurn(0);
            unitList.Add(currentUnitStats);
        }
        //Enemy Units
        GameObject[] enemyUnits = GameObject.FindGameObjectsWithTag("EnemyUnit");
        foreach (GameObject enemyUnit in playerUnits)
        {
            UnitStats currentUnitStats = enemyUnit.GetComponent<UnitStats>();
            currentUnitStats.calculateNextActTurn(0);
            unitList.Add(currentUnitStats);
        }
        unitList.Sort();
        this.turnMenu.SetActive(false);
        this.enemyUnitsMenu.SetActive(false);
        this.ATB();*/
    }

    public void ATB()
    {
        UnitStats currentUnitStats = unitList[0];
        unitList.Remove(currentUnitStats);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
