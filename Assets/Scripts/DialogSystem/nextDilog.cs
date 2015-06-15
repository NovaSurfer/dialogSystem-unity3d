using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class nextDilog : MonoBehaviour, IPointerDownHandler{

    [HideInInspector]
	public string file;         // Имя следующего файла с диалогом
    FileReader FL;

    void Start()
    {
        FL = GameObject.FindGameObjectWithTag("Canvas").GetComponent<FileReader>();
    }

    // Принажатии на ответ..
	public void OnPointerDown(PointerEventData data)
	{
        // Удаляем все кнопки с ответами
        FL.ClearAll();
        if (file != string.Empty)
            // Считаваем новый файл с диалогом, имя которого попадает в переменную file сразу после нажатия кнопки с ответом (имя файла идет после тега "#->")
            CheckingTag();   
	}

    private void CheckingTag()
    {

        switch (file)
        {
            case "/end/": FL.ClearAll(); break;
            default: FL.ReadFromFile(file); break;
        }
    }
}