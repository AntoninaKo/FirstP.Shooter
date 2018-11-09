using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEn : MonoBehaviour {

    public Transform[] SpawnEnemies;
    public GameObject Enemy;
    int quantity;
    float time = 7.0f;


	void Start () {
        InvokeRepeating("Spawn", time, time);
    }

    void Spawn() {
        if (quantity >= 3)
        {
            return;
        }
        else
        {
            int spawnPointIndex = Random.Range(0, SpawnEnemies.Length);
            Instantiate(Enemy, SpawnEnemies[spawnPointIndex].position, SpawnEnemies[spawnPointIndex].rotation);

            quantity++;
        }
    }

    public void MinusQuantity()
    {
        quantity--;
    }

}
