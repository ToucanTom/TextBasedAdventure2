using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D playerRigid;
    float h;
    public GameObject projectile;
    public Transform shotPos;
    public float shotForce = 1000f;
    public float moveSpeed = 10f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //check for button push
        playerRigid = GetComponent<Rigidbody2D>();
         
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(new Vector3(h, v, 0f));
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    print("you hit the up arrow");

        //    playerRigid.velocity = new Vector2(0,4);

        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    print("you hit the down key");
        //    playerRigid.velocity = new Vector2(0,-4);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    print("you hit the left key");
        //    playerRigid.velocity = new Vector2(-4,0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    print("you hit the right key");
        //    playerRigid.velocity = new Vector2(4,0);
        //}
        //shoot?
        if (Input.GetButtonUp("Fire1"))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
              shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
        }
    }
}
