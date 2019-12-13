using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steer : MonoBehaviour
{
    float xAxis = 0;
    Transform steer;
    Vector3 rotasi = new Vector3(); 
    // Start is called before the first frame update
    void Start()
    {
        steer = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        rotasi.Set(0,0,xAxis*-1*90);
        steer.localRotation = Quaternion.Euler(rotasi);
    }
}
