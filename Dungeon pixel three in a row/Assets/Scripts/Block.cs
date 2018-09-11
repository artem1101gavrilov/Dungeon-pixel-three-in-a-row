using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public GameObject[] Circles;

	// Use this for initialization
	void Start () {
        GameObject cir = Instantiate(Circles[Random.Range(0, Circles.Length)], new Vector3(transform.position.x, transform.position.y, -1f), Quaternion.identity, transform);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
