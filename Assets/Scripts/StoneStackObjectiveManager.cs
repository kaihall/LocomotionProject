using System;
using UnityEngine;

// Tracks whether all of the stone stacks have been completed
public class StoneStackObjectiveManager : MonoBehavior
{
	public List<StoneStack> stoneStacks;
	internal Objective stoneStackObj;
	
	void Start() {
		stoneStackObj = GetComponent<Objective>();
	}
	
	void Update() {
		if (!stoneStackObj.cleared) {
			// Iterate over stone stacks to check if they're all cleared
			int cleared = 0;
			foreach (StoneStack stack in stoneStacks) {
				// If the stack is full but its objective hasn't been cleared...
				if (stack.stackSize >= 5 && !stack.objective.cleared) {
					// Clear the objective
					stack.objective.ClearObjective();
				}
				// If the objective has been cleared...
				if (stack.objective.cleared) {
					// Add to the total number of cleared stacks
					cleared += 1;
				}
			}
			
			// Update the objective text to show how many stacks have been completed
			stoneStackObj.objectiveText = "Build Stacks of 5 Stones (" + cleared.ToString() + "/" + stoneStacks.Count.ToString() + ")";
			
			// If all of the stone stacks are finished...
			if (cleared >= stoneStacks.Count) {
				// Clear the overall objective
				stoneStackObj.ClearObjective();
			}
		}
	}
}