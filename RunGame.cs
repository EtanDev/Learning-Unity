using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Warrior war = new Warrior();
        war.Attack();
     
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
