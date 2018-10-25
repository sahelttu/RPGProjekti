using UnityEngine;
using System.Collections;

public class StatAllocationScript{/*

	private string[] statNames = new string[5] {"Vitality", "Endurance", "Attack", "Defense", "Precision"};
	private string[] statDescriptions = new string[5]{"Affects character's health.","Affects character's stamina.","Damage deal modifier.","Damage absorption modifier.","Chance to hit more damage"};
	private bool[] statSelections = new bool[5];
	public int[] pointsToAllocate = new int[5]; //initial stat values for the chosen class
	private int[] baseStatPoints = new int[5]; //initial stat values for the chosen class

	public int availPoints = 5; //points available to allocate
	public bool didRunOnce = false;


		public void DisplayStatAllocationScript(){
		if (!didRunOnce) {
			RetrieveBaseStatPoints ();
			didRunOnce = true;
		}
			DisplayStatToggleSwitches ();
			DisplayStatIncreaseDecreaseButtons ();
		
	}

	private void DisplayStatToggleSwitches(){
		for(int i =0; i < statNames.Length; i++){
			statSelections[i] = GUI.Toggle(new Rect(Screen.width-1090,Screen.height+60*i-450,100,50), statSelections[i], statNames[i]);
			GUI.Label(new Rect(Screen.width-1000,Screen.height+60*i-450,50,50), pointsToAllocate[i].ToString());
			if (statSelections [i]) {
				GUI.Label (new Rect (Screen.width-1090,Screen.height+60*i-425, 150, 100), statDescriptions [i]);
			}
		}
	}
	private void DisplayStatIncreaseDecreaseButtons(){
		for (int i = 0; i < pointsToAllocate.Length; i++) {
			if (pointsToAllocate [i] >= baseStatPoints [i] && availPoints > 0) {
				if (GUI.Button (new Rect (Screen.width-900, Screen.height+60 * i-450, 50, 50), "+")) {
					pointsToAllocate [i] += 1;
					--availPoints;
				}
			}
			if (pointsToAllocate [i] > baseStatPoints [i]) {
				if (GUI.Button (new Rect (Screen.width-950, Screen.height+60 * i -450, 50, 50), "-")) {
					pointsToAllocate [i] -= 1;
					++availPoints;
				}
			}
		}	
	}

	private void RetrieveBaseStatPoints(){
		BasePlayerClass pClass = GameData.PlayerClass;

		pointsToAllocate [0] = pClass.Vitality;
		baseStatPoints [0] = pClass.Vitality;
		pointsToAllocate [1] = pClass.Endurance;
		baseStatPoints [1] = pClass.Endurance;
		pointsToAllocate [2] = pClass.Attack;
		baseStatPoints [2] = pClass.Attack;
		pointsToAllocate [3] = pClass.Defense;
		baseStatPoints [3] = pClass.Defense;
		pointsToAllocate [4] = pClass.Precision;
		baseStatPoints [4] = pClass.Precision;
	}
*/
}
