using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_sc : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
    [SerializeField]
    GameObject enemyContainer;
    // Start is called before the first frame update
    bool stopSpawming = false;
    IEnumerator SpawnRoutine(){

        while(stopSpawming == false)
        {
            Vector3 position = new Vector3(Random.Range(-9.4f,9.4f),7.4f,0);
            GameObject new_enemy = Instantiate(enemyPrefab,position,Quaternion.identity);
            new_enemy.transform.parent = enemyContainer.transform;
            yield return new WaitForSeconds(5.0f);
        }
    }

    public void OnPlayerDeath()
    {
        stopSpawming= true;
    }
    void Start()
    {
        
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}