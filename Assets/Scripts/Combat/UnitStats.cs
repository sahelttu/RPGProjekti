﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnitStats : MonoBehaviour{
    //PELAAJAN STATSIT
    public string UnitName;
    public float HealthMAX;
    public float totalHealth;
    public float HealthCUR;
    public float ManaMAX;
    public float totalMana;
    public float ManaCUR;
    public float Level;
    public float ExpCUR;
    public float ExpREQ;
    private Equipment unitEquipment;
    private JobManager jobManager;

    public float Strength; //Kuinka paljon tekee vahinkoa
    public float totalStrength; //Strength + kaikki bonukset ja kertoimet
    public float Vitality; //Kuinka paljon ottaa vahinkoa
    public float totalVitality; //Vitality + kaikki bonukset ja kertoimet
    public float Agility; //Hahmon vuoro
    public float totalAgility; //Agility + kaikki bonukset ja kertoimet

    public bool dead = false;

    public float Initiative;
    public float Ready = 50f;

    public List<Ability> AbilityBar = new List<Ability>();
    public List<Ability> AbilityCollection = new List<Ability>();



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

    void Awake()
    {
        unitEquipment = GetComponent<Equipment>();
        jobManager = GetComponent<JobManager>();
        Debug.Log(UnitName + " Job: " + jobManager.selectedJob.jobName);
        Debug.Log(UnitName + " Job Desc: " + jobManager.selectedJob.jobDescription);

        totalHealth = HealthMAX * jobManager.selectedJob.HealthMaxMultip;
        Mathf.Round(totalHealth);
        Debug.Log(UnitName + " Health: " + totalHealth);

        totalMana = ManaMAX * jobManager.selectedJob.ManaMaxMultip;
        Mathf.Round(totalMana);
        Debug.Log(UnitName + " Mana: " + totalMana);

        totalStrength = Strength * jobManager.selectedJob.StrengthMultip;
        Mathf.Round(totalStrength);
        Debug.Log(UnitName + " Strength: " + totalStrength);

        totalVitality = Vitality * jobManager.selectedJob.VitalityMultip;
        Mathf.Round(totalVitality);
        Debug.Log(UnitName + " Vitality: " + totalVitality);

        totalAgility = Agility * jobManager.selectedJob.AgilityMultip;
        Mathf.Round(totalAgility);
        Debug.Log(UnitName + " Agility: " + totalAgility);

    }

    void Start()
    {

    }
    /*

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
