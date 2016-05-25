using UnityEngine;
using System.Collections;
using System.Net;
using UnityEngine.Networking;
using UnityEngine.UI;

public class stuff : NetworkBehaviour {
	public NetworkManager nm;
	public void networkStart () {
		nm.networkPort = 7777;
		nm.StartServer ();
	}
	public void networkJoin () {
		getName ();
		InputField input = GameObject.Find ("InputField").GetComponent<InputField> ();
		IPAddress adress;
		nm.networkAddress = input.text;
		if (!(IPAddress.TryParse (nm.networkAddress, out adress))) {
			nm.networkAddress = "88.222.117.174";
		}
		nm.networkPort = 7777;
		nm.StartClient ();
	}
	public void networkHost () {
		nm.StartHost ();
		getName ();
	}
	public void getName(){
		InputField name = GameObject.Find ("UserInput").GetComponent<InputField> ();
		PlayerPrefs.SetString ("Player Name", name.text);
		Debug.Log (name.text);
	}
}