using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class nextDilog : MonoBehaviour, IPointerDownHandler{
	
	public FileReader fileReader;
	
	void Star(){
		fileReader = GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>();
	}
	
	public void OnPointerDown(PointerEventData data)
	{
		fileReader.ClearAll();
	}
}
