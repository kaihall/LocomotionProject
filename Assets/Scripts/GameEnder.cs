using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Ends the game when objectives are completed
public class GameEnder : MonoBehaviour
{
    public ObjectiveManager objectiveManager;
	public Fader blackScreen;
	private bool ending = false;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ending && objectiveManager.objectives.Count == 0) {
			blackScreen.FadeIn();
			StartCoroutine("ChangeScene");
		}
    }
	
	IEnumerator ChangeScene() {
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene("EndScene");
	}
}
