using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMenu : MonoBehaviour {

    public static bool isPlayerTurn = false;
    public GameObject playerturnUI;

    private void Awake()
    {
       playerturnUI.SetActive(false);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isPlayerTurn)
        {
            playerTurn();
        }
	}

    public void playerTurn()
    {
        Debug.Log("PLAYERTURNUI ON");
        playerturnUI.SetActive(true);
    }
}
