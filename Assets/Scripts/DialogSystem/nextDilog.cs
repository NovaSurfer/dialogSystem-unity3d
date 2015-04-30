using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class nextDilog : MonoBehaviour, IPointerDownHandler{

	FileLoader fL;
	public int index = 0;

	void Start()
	{
		fL = GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileLoader>();
	}

	public void OnPointerDown(PointerEventData data)
	{
		CreatingAnswer(4);
	}

	public void CreatingAnswer(int count)
	{
		for(int i = 1; i < count; i++){
			fL.ReadingFromFile(fL.answers[index].nextFile);
			fL.ClearingAnswers();
			fL.AnswerCreation(fL._answerzz[i],fL.textFiles[i], fL.answerID); // 3 answers
			fL.answerID++;
		}
	}
}
