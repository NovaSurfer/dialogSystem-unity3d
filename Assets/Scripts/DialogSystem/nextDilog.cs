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
		fL.ReadingFromFile(fL.answers[index].nextFile);

	}
}
