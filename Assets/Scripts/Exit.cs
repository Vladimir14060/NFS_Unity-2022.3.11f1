using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGame() //выход из игры 
	{
		Application.Quit();
		Debug.Log("Exit");
	}
}
