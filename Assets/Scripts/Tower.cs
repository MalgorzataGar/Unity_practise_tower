using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class Tower : MonoBehaviour {

    public GameObject bulletPrefab;
    public float rotationSpeed = 35;
    List<Collider> colliders = new List<Collider>();
    private Vector3 distance;
    private float dis;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
        if (colliders.Count != 0)
        {
            foreach (Collider element in colliders)
            {
                distance = element.transform.position - transform.position;
                float dis1 = distance.sqrMagnitude;
                if(dis1>=dis)
                {
                    dis = dis1;
                }

            }
            string dis_a = dis.ToString() + "\n";
                    
            string Path = @"C:\Users\USER\Desktop\odl.txt";
            File.AppendAllText(Path, dis_a);
        }
    }
    void OnTriggerEnter(Collider co)
    {
        
        if (co.GetComponent<Monster>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = co.transform;
        }
        if (!colliders.Contains(co))
        {
            colliders.Add(co);
        }
    }
}
