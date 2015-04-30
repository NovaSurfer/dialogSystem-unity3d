using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FileLoader : MonoBehaviour {

	[SerializeField] Text textLabel;
    public List<string> textFiles; 
	public List<string> _answerzz; 
	public List<Answer> answers = new List<Answer>();
	[SerializeField] Button lol;
	int y = -130; 
	public int answerTextID = 0;
	public int textID = 0;
	public int answerID = 0;


	void Start () 
	{
		//DilogCreation(3, textFiles[0], _answerzz[0]);
		DefaultDialog();
	}

	void DefaultDialog()
	{
		ReadingFromFile("testText"); // 2 answers
		//AnswerCreation(_answerzz[0],textFiles[0], 0); // 3 answers
	}

	public void ClearingAnswers()
	{
		GameObject[] buttonList = GameObject.FindGameObjectsWithTag("Finish");
		foreach(GameObject element in buttonList)
		{
			Destroy(element);
			y = -130;
		}
	}

//	void Update()
//	{
//		foreach(string element in textFiles)
//		{
//
//		}
//	}

//	public void DilogCreation(int answerCount, string textName, string answersText)
//	{
//		Dilog dilog01 = new Dilog(answerCount, textName);
//		dilog01.answCount = answerCount;
//		Debug.Log(dilog01.answCount);
//			for(int i = 0; i < dilog01.answCount; i++)
//			{
//				AnswerCreation(answersText, textName, i);
//			}
//	}

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
