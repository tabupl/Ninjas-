using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    [SerializeField] float moveSpeed = 1;


    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKey("w"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1 * moveSpeed * Time.deltaTime, transform.position.z);
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(transform.position.x - 1*moveSpeed*Time.deltaTime, transform.position.y, transform.position.z);
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKey("s"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1 * moveSpeed * Time.deltaTime, transform.position.z);
            anim.SetBool("isWalking", true);
        }
        if (Input.GetKey("d"))
        {
            transform.position = new Vector3(transform.position.x + 1 * moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            anim.SetBool("isWalking", true);
        }

        else
            anim.SetBool("isWalking", false);
    }
}
