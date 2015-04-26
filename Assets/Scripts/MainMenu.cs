using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    ScreenFader scrFader;

	void Start () {
        scrFader = gameObject.GetComponent<ScreenFader>();
	}

    public void OnPlay()
    {
        scrFader.EndScene(1);
    }


}
