using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

	public void changeSceneTo(string sceneName) {
		Application.LoadLevel(sceneName);
	}
	public void Quit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}
}
