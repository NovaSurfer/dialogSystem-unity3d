using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;


public  class FileReader{


	public string ReadFromFile(string fileName)
    {
        //FileStream textFile = new FileStream(Application.dataPath + "/Resources/" + fileName, FileMode.Open);
        //StreamReader textReader = new StreamReader(textFile);
        TextReader textReader = null; // NOTE: TextReader, superclass of StreamReader and StringReader
        TextAsset mydata = Resources.Load(fileName, typeof(TextAsset)) as TextAsset;
        textReader = new StringReader(mydata.text); // returns StringReader;
        return textReader.ReadToEnd(); // Return sting from StringReader;
	}
}


