using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public enum Type {damage, health, shield};
    public Type powerUp;
    
  
	// Use this for initialization
	void Start () {
	

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (powerUp)
        {

            case(Type.damage):
                //increase attack
                break;
            case (Type.health):
                //increase hp
                break;
            case (Type.shield):
                //create a shield around player
                break;
        }
    }

}
