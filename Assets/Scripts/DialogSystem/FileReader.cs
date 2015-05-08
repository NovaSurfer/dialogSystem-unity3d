using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;


public class FileReader : MonoBehaviour{

	public Text mainText;
	public Button answer;
	int y = -130; 

	public void ReadFromFile(string fileName)
    {
		string[] fileLines;
        //FileStream textFile = new FileStream(Application.dataPath + "/Resources/" + fileName, FileMode.Open);
        //StreamReader textReader = new StreamReader(textFile);
        //TextReader textReader = null; // NOTE: TextReader, superclass of StreamReader and StringReader
		TextAsset mydata = Resources.Load(fileName, typeof(TextAsset)) as TextAsset;
        //textReader = new StringReader(mydata.text); // returns StringReader;
		fileLines = mydata.text.Split('\n');
		Debug.Log(fileLines.Length);
		mainText.text = fileLines[0];
		for(int i = 1; i < fileLines.Length; i++)
		{
			if(answer !=null){
			Button answ = (Button)Instantiate(answer);
			answ.transform.parent = this.gameObject.transform;
			answ.GetComponent<RectTransform>().localPosition = new Vector3(0, y = y - 43, 0);
			Text answText = answ.GetComponentInChildren<Text>();
			answText.text = fileLines[i];
			}
		}
	}

	void Start(){
		ReadFromFile("testText");
	}

	public void ClearAll(){
		mainText.text = "";
		GameObject[] buttonList = GameObject.FindGameObjectsWithTag("Finish");
		foreach(GameObject element in buttonList)
		{
			Destroy(element);
			y = -130;
		}
	}
}


