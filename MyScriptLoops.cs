using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptLoops : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
        	for (int i = 0; i < 10; i++)
        		{
            		Debug.Log("Printed " + i);
        		}

        	int a = 0;

        	while(true)
        		{
            		Debug.Log("printed " + a);
            		a++;
        		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
