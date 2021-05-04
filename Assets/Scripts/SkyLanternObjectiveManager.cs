using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLanternObjectiveManager : MonoBehaviour
{
	public List<SkyLantern> lanterns;
	internal Objective lanternObj;
	
	void Start() {
		lanternObj = GetComponent<Objective>();
	}
	
	void Update() {
		if (!lanternObj.cleared) {
			// Iterate over lanterns to check if they're all cleared
			int cleared = 0;
			foreach (SkyLantern lantern in lanterns) {
				// If the objective has been cleared...
				if (lantern.objective.cleared) {
					// Add to the total number of cleared stacks
					cleared += 1;
				}
			}
			
			// Update the objective text to show how many lanterns have been released
			lanternObj.objectiveText = "Release Floating Lanterns (" + cleared.ToString() + "/" + lanterns.Count.ToString() + ")";
			
			// If all of the stone stacks are finished...
			if (cleared >= lanterns.Count) {
				// Clear the overall objective
				lanternObj.ClearObjective();
			}
		}
	}
}