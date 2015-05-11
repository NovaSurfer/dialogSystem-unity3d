using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class nextDilog : MonoBehaviour, IPointerDownHandler{

	public string file;
	
	public void OnPointerDown(PointerEventData data)
	{
		GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>().ClearAll();
		if(file != null && file != "")
			GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>().ReadFromFile(file);

	}
}