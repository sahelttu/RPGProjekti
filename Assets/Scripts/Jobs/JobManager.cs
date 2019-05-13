using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour {

    public CharacterJob currentJob;
    public string currentJobName;
    public CharacterJob selectedJob;
    public UnitStats unitStats;
    public int jobLV;
    public int knightLV;
    public int thiefLV;



    private void Awake()
    {
        unitStats = gameObject.GetComponent<UnitStats>();
        UpdateStats();
        currentJobName = currentJob.jobName;
    }

    private void ChangeJobs()
    {
        SaveLevel();
        currentJob = selectedJob;
        currentJobName = currentJob.jobName;
        UpdateStats();
        LoadLevel();
    }

    private void UpdateStats()
    {
        Debug.Log(currentJob + ". Updating stats.");
        unitStats.totalStrength = Mathf.Round(unitStats.Strength * currentJob.JobSTR);
        unitStats.totalVitality = Mathf.Round(unitStats.Vitality * currentJob.JobVIT);
        unitStats.totalAgility = Mathf.Round(unitStats.Agility * currentJob.JobAGI);
    }


    // Tallentaa jobLV:n arvon nykyisen jobin leveliin

    private void SaveLevel()
    {
        switch(currentJobName)
        {
            case "Knight":
                Debug.Log("Saving the KnightLV");
                knightLV = jobLV;

                break;

            case "Thief":
                Debug.Log("Saving the ThiefLV");
                thiefLV = jobLV;
                break;
        }

    }

    // Tallentaa nykyisen jobin levelin jobLV:hen

    private void LoadLevel()
    {
        switch(currentJobName)
        {
            case "Knight":
                Debug.Log("Loading the KnightLV");
                jobLV = knightLV;

                break;

            case "Thief":
                Debug.Log("Loading the ThiefLV");
                jobLV = thiefLV;
                break;
        }
    }

    //Nostaa nykyisen jobin leveliä

    private void JobLvlUp()
    {
        Debug.Log("Job level up");
        jobLV++;
    }


    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Spacebar");
            ChangeJobs();
        }
        if (Input.GetButtonDown("Sprint")){
            JobLvlUp();
        }
    }

}
