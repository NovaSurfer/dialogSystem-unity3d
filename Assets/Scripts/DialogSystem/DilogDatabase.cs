using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DilogDatabase : MonoBehaviour {

	public List<Dialog> dilog = new List<Dialog>();

	void Start()
	{
		dilog.Add(new Dialog("testText01", 2, 0));
		dilog.Add(new Dialog("testText02", 1, 1));
		dilog.Add(new Dialog("testText03", 3, 2));
	}
}
