using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FileLoader : MonoBehaviour {

	[SerializeField] Text textLabel;
    [SerializeField] string fileName;

	void Start () {
        FileReader lol = new FileReader();
        textLabel.text = lol.ReadFromFile(fileName); 
	}
}
