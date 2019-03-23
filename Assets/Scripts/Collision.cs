using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float radius = 10f;
    private Vector3 distance;
    public float dis;
    public GameObject boat;
    List<Collider> colliders = new List<Collider>();
    Collider max;

    void Update()
    {
        float max_dis = 0;
        if (colliders.Count != 0)
        {
            foreach (Collider element in colliders)
            {
                distance = element.transform.position - boat.transform.position;
                float current_dis = distance.sqrMagnitude;
                if (current_dis > max_dis)
                {
                    max_dis = current_dis;
                    max = element;
                }
                dis = max_dis;

                colliders.Clear();

            }
        }

    }

    void OnTriggerEnter(Collider co)
    {
        if (!colliders.Contains(co))
        {
            colliders.Add(co);
        }
    }

    public float get_distance()
    {
        return dis;
    }
     
}
