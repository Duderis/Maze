using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class stuff : NetworkBehaviour {
	public NetworkManager nm;
	public void networkStart () {
		nm.networkPort = 7777;
		nm.StartServer ();
	}
	public void networkJoin () {
		InputField input = GameObject.Find ("InputField").GetComponent<InputField> ();
		nm.networkAddress = "88.222.117.174";//input.text;
		nm.networkPort = 7777;
		nm.StartClient ();
	}
	public void networkHost () {
		nm.StartHost ();
	}
}