using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour {

	
	void Start () {
        GameObject castle = GameObject.Find("Castle");
        if (castle)
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
    }
    void OnTriggerEnter(Collider co)
    {
        
        if (co.name == "Castle")
        {
            co.GetComponentInChildren<Health>().decrease();
            Destroy(gameObject);
        }
    }

}
