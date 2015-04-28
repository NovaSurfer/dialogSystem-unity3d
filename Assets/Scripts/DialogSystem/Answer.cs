using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Answer{


	public int index;
	public string answ, nextFile;
	
	public Answer(string answer, string nextFileText, int textID)
	{
		answ = answer;
		index = textID;
		nextFile = nextFileText;
	}


}
