using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour {

	public GameView GameView = null;
	void Start () {
		ApplicationFacade facade = new ApplicationFacade();
		facade.Start(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
