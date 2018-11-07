using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobBase {

    private string JobName;
    private string JobDescription;

    private int HealthMultip;
    private int ManaMultip;
    private int StrengthMultip;
    private int VitalityMultip;
    private int AgilityMultip;

    public string jobName
    {
        get { return JobName; }
        set { JobName = value; }
    }

    public string jobDescription
    {
        get { return JobDescription; }
        set { JobDescription = value; }
    }

    public int healthMulti
    {
        get { return HealthMultip; }
        set { HealthMultip = value; }
    }

    public int manaMulti
    {
        get { return ManaMultip; }
        set { ManaMultip = value; }
    }

    public int strengthMulti
    {
        get { return StrengthMultip; }
        set { StrengthMultip = value; }
    }

    public int vitalityMulti
    {
        get { return VitalityMultip; }
        set { VitalityMultip = value; }
    }

    public int agilityMulti
    {
        get { return AgilityMultip; }
        set { AgilityMultip = value; }
    }
 
}
