using UnityEngine;
using System.Collections;

public class CreationGUI : MonoBehaviour {/*

	public enum CreateAPlayerStates{
		SELECTORIGIN, //Display all origins
		SELECTCLASS, //Display all classes
		ALLOCATESTATS, //Put in the stats
		FINALSETUP, //name and summary
		ENDSCREEN //displays the quit button

	}

	private DisplayCharacterCreateFunction displayFunctions = new DisplayCharacterCreateFunction();
	public static CreateAPlayerStates currentState;


	// Use this for initialization
	void Start () {
		currentState = CreateAPlayerStates.SELECTORIGIN;
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case (CreateAPlayerStates.SELECTORIGIN):
			break;
		case(CreateAPlayerStates.SELECTCLASS):
			break;
		case(CreateAPlayerStates.ALLOCATESTATS):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		case(CreateAPlayerStates.ENDSCREEN):
			break;
		}
	}

	void OnGUI(){
		displayFunctions.DisplayMainItems ();
		if (currentState == CreateAPlayerStates.SELECTCLASS) //Class Selection Display 
		{
			displayFunctions.DisplayClassSelections();
		}
		if (currentState == CreateAPlayerStates.SELECTORIGIN) //Origin Selection Display
		{
			displayFunctions.DisplayOriginSelections ();
		}
		if (currentState == CreateAPlayerStates.ALLOCATESTATS) //Stat Display 
		{
			displayFunctions.DisplayStatAllocation();
		}
		if (currentState == CreateAPlayerStates.FINALSETUP) //Final Setup Display
		{
			Debug.Log (GameData.Vitality);
			displayFunctions.DisplayFinalSetup();
		}
		if (currentState == CreateAPlayerStates.ENDSCREEN) //End Screen
		{
			displayFunctions.DisplayEndScreen ();
		}

	}*/
}
