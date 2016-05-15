using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System;

public class GameMenager : NetworkBehaviour {
    public Maze mazePref;
    private Maze mazeint;

	[SyncVar]
	int sed;

	// Use this for initialization
	void Start(){
		if (isServer) {
			sed = UnityEngine.Random.Range (1, 50000);
		}
		BeginGame ();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            RestartGame();
	}

    private void RestartGame()
    {
        Destroy(mazeint.gameObject);
        BeginGame();
    }

    private void BeginGame()
    {
		mazeint = Instantiate (mazePref) as Maze;
		mazeint.seed = sed;
		mazeint.Generate ();
    }
}
