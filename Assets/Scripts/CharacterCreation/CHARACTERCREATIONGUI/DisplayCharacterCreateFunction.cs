using UnityEngine;
using System.Collections;

public class DisplayCharacterCreateFunction{
    /*
	private StatAllocationScript statAllocationScript = new StatAllocationScript();
	private int classSelection;
	public Texture Class1;
	private string[] classSelectionNames= new string[] {"Knight","Mage","Warrior"};
	private string playerName = "Enter Name";

	public void DisplayClassSelections (){
		//Toggle buttons for each class
		//Selection grid
		//THIS IS WHAT THE USER WILL SEE
		GUI.Box (new Rect (Screen.width-255, Screen.height-210, Screen.width-1500, Screen.height-910),"");
		GUI.Box (new Rect (Screen.width-500, Screen.height-210, Screen.width-1500, Screen.height-910),"");
		classSelection=GUI.SelectionGrid(new Rect(Screen.width-1050, Screen.height-350, 200, 100), classSelection, classSelectionNames, 1);
		GUI.Label (new Rect (Screen.width-475, Screen.height-400, Screen.width-1100, Screen.height+100), FindClassDesc(classSelection));
		GUI.Label (new Rect (Screen.width-700, Screen.height/2, 300, 300), FindClassStats(classSelection));
		GUI.Label (new Rect (Screen.width-1050, Screen.height-150, 200, 100), "2/4");
		GUI.Label (new Rect (Screen.width-750, Screen.height-500, 250, 200 ), "SELECT YOUR CLASS\n\nClasses have different base stats and gameplay");
	
	}

	private string FindClassDesc( int classSelection){
		if (classSelection == 0) {
			BasePlayerClass tempClass = new BaseKnight ();
			return tempClass.CharacterClassDesc;
		} else if (classSelection == 1) {
			BasePlayerClass tempClass = new BaseMage ();
			return tempClass.CharacterClassDesc;
		} else if (classSelection == 2) {
			BasePlayerClass tempClass = new BaseWarrior ();
			return tempClass.CharacterClassDesc;
		}
		return "ERROR: NO CLASS FOUND";
	}

	private string FindClassStats(int classSelection){
		if (classSelection == 0) {
			BasePlayerClass tempClass = new BaseKnight ();
			string tempStats = "Vitality: " + tempClass.Vitality + "\n" + "Endurance: " + tempClass.Endurance + "\n" + "Attack: " + tempClass.Attack + "\n" + "Defense: " + tempClass.Defense + "\n" + "Precision: " + tempClass.Precision;
			return tempStats;
		} else if (classSelection == 1) {
			BasePlayerClass tempClass = new BaseMage ();
			string tempStats = "Vitality: " + tempClass.Vitality + "\n" + "Endurance: " + tempClass.Endurance + "\n" + "Attack: " + tempClass.Attack + "\n" + "Defense: " + tempClass.Defense + "\n" + "Precision: " + tempClass.Precision;
			return tempStats;
		} else if (classSelection == 2) {
			BasePlayerClass tempClass = new BaseWarrior ();
			string tempStats = "Vitality: " + tempClass.Vitality + "\n" + "Endurance: " + tempClass.Endurance + "\n" + "Attack: " + tempClass.Attack + "\n" + "Defense: " + tempClass.Defense + "\n" + "Precision: " + tempClass.Precision;
			return tempStats;
		}
		return "ERROR: NO STATS FOUND";
	}

	public void DisplayFinalSetup(){
		//names and stuff
		GUI.Box (new Rect (Screen.width-280, Screen.height-210, Screen.width-1500, Screen.height-910),"");
		GUI.Box (new Rect (Screen.width-570, Screen.height-210, Screen.width-1500, Screen.height-910),"");
		GUI.Label (new Rect (Screen.width-770, Screen.height-400, Screen.width-1100, Screen.height+100), "Class:" + GameData.PlayerClass.CharacterClassName + "\n\n" + FindClassDesc(classSelection));
		GUI.Label (new Rect (Screen.width-475, Screen.height-400, Screen.width-1100, Screen.height+100), "Origin:" + GameData.PlayerOrigin.CharacterOriginName + "\n\n" + FindOriginDesc(originSelection));
		GUI.Label (new Rect (Screen.width-750, Screen.height-500, 250, 200 ), "SUMMARY\n\nRemember to give your character a name and choose gender!");
		GUI.Label (new Rect (Screen.width-1050, Screen.height-150, 200, 100), "4/4");
		playerName = GUI.TextArea(new Rect(Screen.width-1050,Screen.height-450,150,35), playerName, 40);
		genderSelection = GUI.SelectionGrid (new Rect (Screen.width - 1050, Screen.height - 350, 200, 100), genderSelection, genderTypes, 1);
	}
		
	private void ChooseClass(int classSelection){
		if (classSelection == 0) {
			GameData.PlayerClass = new BaseKnight();	
		} else if (classSelection == 1) {
			GameData.PlayerClass = new BaseMage();
		} else if (classSelection == 2){
			GameData.PlayerClass = new BaseWarrior ();
		}
	}

	public void DisplayEndScreen(){
		GUI.Label (new Rect (Screen.width/2-100, Screen.height/2-100, 250, 200), "Welcome to the DemoWorld, " + GameData.PlayerClass.CharacterClassName + " of " + GameData.PlayerOrigin.CharacterOriginName + "!");
		GUI.Label (new Rect (Screen.width/2-100, Screen.height/2, 250, 200), "This is the end of the demo. Please press the Quit button to close the program.");
		if (GUI.Button(new Rect(Screen.width/2,Screen.height/2+100, 50, 30), "QUIT")){
			Application.Quit();
		}
	}


	public void DisplayMainItems(){
		GUI.Box (new Rect (Screen.width-100, Screen.height-100, Screen.width-2350, Screen.height-1200),"");
		if (CreationGUI.currentState != CreationGUI.CreateAPlayerStates.FINALSETUP && CreationGUI.currentState != CreationGUI.CreateAPlayerStates.ENDSCREEN) {
			if (GUI.Button (new Rect (Screen.width-350, Screen.height-200, 100, 50), "NEXT>")) {
				if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.SELECTORIGIN) {
					ChooseOrigin (originSelection);
					CreationGUI.currentState = CreationGUI.CreateAPlayerStates.SELECTCLASS;
				} else if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.SELECTCLASS) {
					ChooseClass (classSelection);
					CreationGUI.currentState = CreationGUI.CreateAPlayerStates.ALLOCATESTATS;
				} else if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.ALLOCATESTATS) {
					GameData.Vitality= statAllocationScript.pointsToAllocate [0];
					GameData.Endurance= statAllocationScript.pointsToAllocate [1];
					GameData.Attack = statAllocationScript.pointsToAllocate [2];
					GameData.Defense= statAllocationScript.pointsToAllocate [3];
					GameData.Precision= statAllocationScript.pointsToAllocate [4];
					CreationGUI.currentState = CreationGUI.CreateAPlayerStates.FINALSETUP;
				}
		}
		} else if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.FINALSETUP){
			if (GUI.Button (new Rect (Screen.width-380, Screen.height-200, 100, 50), "DONE>")) {
				Debug.Log ("CREATION SUCCESSFUL");
				GameData.PlayerName = playerName;
				if (genderSelection == 0) {
					GameData.isMale = true;
				} else if (genderSelection == 1) {
					GameData.isMale = false;
				}
				SaveData.SaveAllData ();
				CreationGUI.currentState = CreationGUI.CreateAPlayerStates.ENDSCREEN;
			}
		}

			if(CreationGUI.currentState != CreationGUI.CreateAPlayerStates.SELECTORIGIN && CreationGUI.currentState != CreationGUI.CreateAPlayerStates.ENDSCREEN){
		if (GUI.Button (new Rect (Screen.width-485, Screen.height-200, 100, 50), "< BACK")) {
				if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.ALLOCATESTATS) {
					statAllocationScript.didRunOnce = false;
					statAllocationScript.availPoints = 5;
					GameData.PlayerClass = null;
					CreationGUI.currentState = CreationGUI.CreateAPlayerStates.SELECTCLASS;
				} else if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.FINALSETUP) {
					CreationGUI.currentState = CreationGUI.CreateAPlayerStates.ALLOCATESTATS;
				} else if (CreationGUI.currentState == CreationGUI.CreateAPlayerStates.SELECTCLASS) {
					CreationGUI.currentState = CreationGUI.CreateAPlayerStates.SELECTORIGIN;
				}
			}
		}
	}*/
}