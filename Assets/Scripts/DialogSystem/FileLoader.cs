using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FileLoader : MonoBehaviour {

	[SerializeField] Text textLabel;
   // [SerializeField] string fileName; // Default message
	public List<Answer> answers = new List<Answer>();
	[SerializeField] Button lol;
	int y = -130; 


	void Start () {
		ReadingFromFile("testText");
		AnswerCreation("Hello!","testText 1", 0);
		AnswerCreation("Bye!","testText 2", 1);
	}

	public void ReadingFromFile(string fileName)
	{
		FileReader lol = new FileReader();
		textLabel.text = lol.ReadFromFile(fileName); 
	}

	public void AnswerCreation(string answText, string nextText, int answIndex)
	{
		answers.Add(new Answer(answText, nextText, answIndex));
		Button lol01 = (Button)Instantiate(lol);
		lol01.transform.parent = this.gameObject.transform;
		lol01.GetComponent<RectTransform>().localPosition = new Vector3(0, y = y - 43, 0);
		Text loltext = lol01.GetComponentInChildren<Text>();
		loltext.text = answers[answIndex].answ;
		lol01.GetComponent<nextDilog>().index = answIndex;

	}
}
