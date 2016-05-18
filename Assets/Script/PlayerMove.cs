using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayerMove : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer)
			return;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, y, 0.0f);
        this.gameObject.GetComponent<Rigidbody>().velocity = move * 3;
    }
    /*void OnCollisionEnter(Collision collision)
    {
        Debug.Log("asdasdasdasd");
        Vector3 move;
        if (collision.gameObject.tag=="Wall")
        {
            if (Input.GetAxis("Vertical") != 0)
            {
                move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
                this.gameObject.GetComponent<Rigidbody>().velocity = move * 3;
            }
            if (Input.GetAxis("Horizontal") != 0)
            {
                move = new Vector3(0, Input.GetAxis("Vertical"), 0);
                this.gameObject.GetComponent<Rigidbody>().velocity = move * 3;
            }
        }
    }*/
}
