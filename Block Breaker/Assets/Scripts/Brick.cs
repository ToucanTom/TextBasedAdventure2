using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int hp = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(hp == 0)
        {
            Destroy(this);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
