using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptArrays : MonoBehaviour 
{

    int[] nums = new int[10];

	// Use this for initialization
	void Start ()
	{
        	for(int i = 0; i < nums.Length; i++)
        		{
            		nums[i] = Random.Range(1, 100);
        		}

        	for (int i = 0; i < nums.Length; i++)
        		{
            		Debug.Log("Element: " + i + " is " + nums[i]);
        		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
