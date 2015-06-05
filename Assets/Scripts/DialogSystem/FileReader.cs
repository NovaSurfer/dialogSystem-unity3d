using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;


public class FileReader : MonoBehaviour{

	public string defaultDilogFile;         // Начальный файл с диалогом
	public Text dialogWindowText;           // Элемент *текста* главного окна диалога
	public Button answerButton;             // Префаб с кнопкой ответа
	int y = -110;                           // Начальная координата первой кнопки с ответом по оси Y

	public void ReadFromFile(string fileName)
    {
		string[] answersArray;
        TextAsset mydata = Resources.Load(fileName, typeof(TextAsset)) as TextAsset;                                            // Текстовый файл загружаемый из папки Resources
		string[] fileLines = mydata.text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);    // Разбиваем текстовый файл на строки и добавляем в массив, при этом игнорируем пустые строки.
		dialogWindowText.text = fileLines[0];                                                                                   // Присваиваем первую строку тексту главного диалогового окна
		for(int i = 1; i < fileLines.Length; i++) {                                                                             // Игнорируя первую строку запускаем цикл для создания ответов
			if(answerButton != null) {                                                                                          
				Button ansBtn = (Button)Instantiate(answerButton);                                                              // Создание кнопки на сцене
				answersArray = fileLines[i].Split(new string[] { "#->" }, StringSplitOptions.None);                             // Режем строку с текстом ответа до тега "#->"
				//Debug.Log("["+answersArray[0]+"]" + "["+answersArray[1]+"]");
                ansBtn.GetComponent<nextDilog>().file = answersArray[1];                                                        // Второй "кусок", отрезанной выше строки answersArray[1], присваиваем переменной file класса nextDilog
				ansBtn.transform.parent = this.gameObject.transform;                                                            // Делаем созданную кнопку дочерней по отношению к Canvas (!для этого скрипт должен быть прикреплен к Canvas!)
				ansBtn.GetComponent<RectTransform>().localPosition = new Vector3(0, y = y - 43, 0);                             // Смещаем нашу кнопку вниз на 43 пикселя от позиции последней кнопки (только по оси Y)
				Text answText = ansBtn.GetComponentInChildren<Text>();                                                          // Получаем дочерний текстовый объект нашей кнопки
                answText.text = answersArray[0];                                                                                // Присваиваем текст к кнопке из answersArray[0], который был получен ранее (до тега "#->")
			}
		}
	}

	void Start(){
		ReadFromFile(defaultDilogFile);    // Начинаем считывать файл заданный по умолчанию
	}

	public void ClearAll(){                // Очистка ответов
		dialogWindowText.text = string.Empty;
		GameObject[] buttonList = GameObject.FindGameObjectsWithTag("Answer");
		foreach(GameObject element in buttonList)
		{
			Destroy(element);
			y = -130;
		}
	}
}


