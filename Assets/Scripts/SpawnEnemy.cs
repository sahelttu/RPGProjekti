using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemy : MonoBehaviour {

    [SerializeField]
    private GameObject enemyEncounterPrefab;

    private bool spawning = false;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Combat")
        {
            if (this.spawning)
            {
                Vector3 enemyPosition = new Vector3(Random.Range(29.0f, 79.0f), 0.5f, Random.Range(15.0f, 35.0f));
                Instantiate(enemyEncounterPrefab, enemyPosition, Quaternion.identity);
            }
            SceneManager.sceneLoaded -= OnSceneLoaded;
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player entered collider");
            this.spawning = true;
            SceneManager.LoadScene("Combat");
        }
    }
}
