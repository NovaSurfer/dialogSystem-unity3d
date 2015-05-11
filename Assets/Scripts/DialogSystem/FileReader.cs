using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;


public class FileReader : MonoBehaviour{

	public string defaultDilogFile;
	public Text dialogWindowText;
	public Button answerButton;
	int y = -130; 

	public void ReadFromFile(string fileName)
    {
		string[] answersArray;
		TextAsset mydata = Resources.Load(fileName, typeof(TextAsset)) as TextAsset; 
		string[] fileLines = mydata.text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
		dialogWindowText.text = fileLines[0];
		for(int i = 1; i < fileLines.Length; i++) {
			if(answerButton != null) {
				Button ansBtn = (Button)Instantiate(answerButton);
				answersArray = fileLines[i].Split(new string[] { "#->" }, StringSplitOptions.None);
				//Debug.Log("["+answersArray[0]+"]" + "["+answersArray[1]+"]");
				ansBtn.GetComponent<nextDilog>().file = answersArray[1];
				ansBtn.transform.parent = this.gameObject.transform;
				ansBtn.GetComponent<RectTransform>().localPosition = new Vector3(0, y = y - 43, 0);
				Text answText = ansBtn.GetComponentInChildren<Text>();
				answText.text = answersArray[0];
			}
		}
	}

	void Start(){
		ReadFromFile(defaultDilogFile);
	}

	public void ClearAll(){
		dialogWindowText.text = "";
		GameObject[] buttonList = GameObject.FindGameObjectsWithTag("Finish");
		foreach(GameObject element in buttonList)
		{
			Destroy(element);
			y = -130;
		}
	}
}


