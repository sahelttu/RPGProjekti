using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnitStats : MonoBehaviour{
    //PELAAJAN STATSIT
    public string UnitName;
    public float HealthMAX;
    public float HealthCUR;
    public float ManaMAX;
    public float ManaCUR;
    public float Level;
    public float ExpCUR;
    public float ExpREQ;
    private Equipment unitEquipment;

    public float Strength; //Kuinka paljon tekee vahinkoa
    public float totalStrength; //Strength + kaikki bonukset
    public float Vitality; //Kuinka paljon ottaa vahinkoa
    public float Agility; //Hahmon vuoro

    public bool dead = false;

    public float Initiative;
    public float Ready = 50f;

    public Ability[] activeAbilities;
    public Ability[] abilityCollection;



    public enum ATBStates
    {
        START,
        WAIT,
        TURN,
        CAST,
        ACT,
        DEAD
    };

    ATBStates currentState;
/*
    void Awake()
    {
        unitEquipment = GetComponent<Equipment>();
        currentState = ATBStates.START;

        //totalStrength = Strength + unitEquipment.weapon1.damage;
    }
    private void Start()
    {
        currentState = ATBStates.START;
    }

    private void Update()
    {
        Debug.Log(Initiative);
        switch (currentState)
        {
            case (ATBStates.START):
                //Tappelun alussa tapahtuvat procit
                currentState = ATBStates.WAIT;
                break;
            case (ATBStates.WAIT):
                Initiative += Time.deltaTime * 1.0f * (0.5f * Agility);
                if (Initiative >= Ready)
                {
                    currentState = ATBStates.TURN;
                    Debug.Log(currentState);
                }
                //Odottaa vuoroa
                break;
            case (ATBStates.TURN):
                if (gameObject.CompareTag("PlayerUnit"))
                {
                    Debug.Log("PlayerCharacter");
                }
                //Pelaajan vuoro
                break;
            case (ATBStates.CAST):
                //Pelaajan abilityn castaus aika
                break;
            case (ATBStates.ACT):
                //Pelaaja suorittaa abilityn
                break;
            case (ATBStates.DEAD):
                //Pelaaja on kuollut
                break;
            
        }
    }
*/


    /*public void calculateNextActTurn(int Initiative)
    {
        Debug.Log("calculateNextActTurn");
        do
        {
            this.Initiative += Time.deltaTime * (0.01f * this.Agility);
            Debug.Log(this.Initiative);
        }
        while (this.Initiative < 10f);
        Debug.Log("calculateNextActTurn done");

        return;
    }*/

    /*public int CompareTo(object otherStats)
    {
        return Initiative.CompareTo(((UnitStats)otherStats).Initiative);
    }*/

    public bool isDead()
    {
        return this.dead;
    }
}
