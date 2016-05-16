using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PlayerInitialize : NetworkBehaviour {
	public GameObject cam;
	// Use this for initialization
	void Start () {
		if (isLocalPlayer){
			GameObject maincamera = Instantiate (cam);
			maincamera.transform.parent = this.gameObject.transform;
			maincamera.transform.position = this.gameObject.transform.localPosition;
			maincamera.transform.Translate (0,(float)-2.61,-15,Space.World);
		}
	}
}