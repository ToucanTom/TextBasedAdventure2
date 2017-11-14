using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
    public float spinSpeed;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-spinSpeed, spinSpeed) ,ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
