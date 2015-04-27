using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Dialog : MonoBehaviour{

	public string name;
	public int count;
	public int index;
	public Button answer;
	
	public Dialog(string fileName, int answCount, int ID)
	{
		name = fileName;
		count = answCount;
		index = ID;
	}


}
