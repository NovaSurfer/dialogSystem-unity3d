using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class nextDilog : MonoBehaviour, IPointerDownHandler{
	
	public FileReader fileReader;
	public string file;
	
	void Star(){
	}
	
	public void OnPointerDown(PointerEventData data)
	{
		GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>().ClearAll();
		GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>().ReadFromFile(file);

	}
}
