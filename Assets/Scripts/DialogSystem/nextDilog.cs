using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class nextDilog : MonoBehaviour, IPointerDownHandler{

	public string file;         // Имя следующего файла с диалогом
	
	public void OnPointerDown(PointerEventData data)                                                    // Принажатии на ответ..
	{
		GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>().ClearAll();               // Удаляем все кнопки с ответами
		if(file != string.Empty)
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>().ReadFromFile(file);   // Считаваем новый файл с диалогом, имя которого попадает в переменную file сразу после нажатия кнопки с ответом (имя файла идет после тега "#->")

	}
}