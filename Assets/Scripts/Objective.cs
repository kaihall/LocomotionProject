using System;
using UnityEngine;

public class Objective : MonoBehavior
{
	internal ObjectiveManager objectiveManager;
	internal bool cleared = false;
	public string objectiveText = "";
	
	public void ClearObjective() {
		// When clearing the objective, get the manager to remove it
		objectiveManager.ClearObjective(this);
		// Add a "[CLEARED]" modifier in front of the text
		objectiveText = "[CLEARED] " + objectiveText;
		// Mark it as cleared
		cleared = true;
	}
}