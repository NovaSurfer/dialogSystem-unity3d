using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;


public  class FileReader : MonoBehaviour{


	public string ReadFromFile(string fileName)
    {
		List<string> fileLines;
        //FileStream textFile = new FileStream(Application.dataPath + "/Resources/" + fileName, FileMode.Open);
        //StreamReader textReader = new StreamReader(textFile);
        TextReader textReader = null; // NOTE: TextReader, superclass of StreamReader and StringReader
        TextAsset mydata = Resources.Load(fileName, typeof(TextAsset)) as TextAsset;
        textReader = new StringReader(mydata.text); // returns StringReader;
//		fileLines = textReader.ReadToEnd().Split().ToString();
		return null;  // Return sting from StringReader;
	}
}


