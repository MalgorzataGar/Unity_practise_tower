using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
   
    public GameObject monsterPrefab;

    
    public float interval = 3;
    
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(monsterPrefab, transform.position, Quaternion.identity);
    }
}
