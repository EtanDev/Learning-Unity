using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptCoroutine : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
        StartCoroutine(executeSomething());
       	/* 
        StartCoroutine("executeSomething");
        StopCoroutine("executeSomething");
	*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    IEnumerator executeSomething()
    {
        yield return new WaitForSeconds(2f);

        Debug.Log("Waited 2 seconds to print.");
    }
}
