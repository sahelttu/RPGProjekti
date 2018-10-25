using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour {

	public static GameManager control;

	public string p1name;
	public float p1health;
	public float p1currenthealth;
	public float p1sp;
	public float p1currentsp;
	public float p1currentlv;
	public float p1currentexp;
	public float p1requiredexp;
	public float p1strength;
	public float p1vitality;
	public float p1agility;

	//public static List<BaseAbility> p1abilitylist;
	//public BaseAbility AttackAbility = new Attack ();

	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}
	}
	
	public void Save ()
	{
        Debug.Log("Saving...");
        BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open(Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);

		PlayerData data = new PlayerData ();
		data.p1name = p1name;
		data.p1health = p1health;
		data.p1currenthealth = p1currenthealth;
		data.p1sp = p1sp;
		data.p1currentsp = p1currentsp;
		data.p1currentlv = p1currentlv;
		data.p1currentexp = p1currentexp;
		data.p1requiredexp = p1requiredexp;
		data.p1strength = p1strength;
		data.p1vitality = p1vitality;
		data.p1agility = p1agility;

		bf.Serialize (file, data);
		file.Close ();
        Debug.Log("Saving complete!");
	}

	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/playerinfo.dat"))
		{
            Debug.Log("Loading...");
            BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();

			p1name = data.p1name;
			p1health = data.p1health;
			p1currenthealth = data.p1currenthealth;
			p1sp = data.p1sp;
			p1currentsp = data.p1currentsp;
			p1currentlv = data.p1currentlv;
			p1currentexp = data.p1currentexp;
			p1requiredexp = data.p1requiredexp;
			p1strength = data.p1strength;
			p1vitality = data.p1vitality;
			p1agility = data.p1agility;
            Debug.Log("Loading complete!");
		}
	}
	//Resets the character stats to its original values. Does NOT save them.
	public void NewGame()
	{
        Debug.Log("New game started");
		/*
	CHARACTER ONE:
	CharacterName = "TestHero1";
	MaxHP = 100;
	MaxSP = 100;
	CurrentLV = 1;
	CurrentEXP = 0;
	RequiredEXP = 5;
	Strength = 30;
	Vitality = 10;
	Agility = 15;
	*/
		p1name = "TestHero1";
		p1health = 100;
		p1sp = 100;
		p1currentsp = 100;
		p1currenthealth = 100;
		p1currentlv = 1;
		p1currentexp = 0;
		p1requiredexp = 5;
		p1strength = 30;
		p1vitality = 10;
		p1agility = 15;

	}
}

[Serializable]
class PlayerData
{
	public string p1name;
	public float p1health;
	public float p1currenthealth;
	public float p1sp;
	public float p1currentsp;
	public float p1currentlv;
	public float p1currentexp;
	public float p1requiredexp;
	public float p1strength;
	public float p1vitality;
	public float p1agility;
}
