using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneStack : MonoBehaviour
{
	public List<GameObject> stones;			// List of all stones in the stack. Public for testing purposes.
	private int lastStoneSize = 6;			// Size of the last stone added.
	internal int stackSize = 0;				// How many stones have been added to the stack.
	internal Objective objective;			// The objective attached to this stack
	public TextFader message;					// The congratulatory message that appears when this stack is complete (or, rather, its required Fader component
	
	void Start() {
		objective = GetComponent<Objective>();
		
		stones = new List<GameObject>();
		foreach (Transform child in transform) {
			stones.Add(child.gameObject);			// Add the stones that are attached to this object to the list of stones
			child.gameObject.SetActive(false);		// Deactivate the stones so that they don't show up at the beginning
		}
	}
	
	// When an object is within the stack's collider...
	void OnTriggerStay(Collider other) {
		// Look for a StackableStone component to determine if it is a stone
		StackableStone stone = other.gameObject.GetComponent<StackableStone>();
		
		// If it is a stone, it is not being held, and it is the right size (1 smaller than the most recent stone)...
		if (stone && !stone.held && lastStoneSize - stone.size == 1) {
			// Update the size of the last stone added
			lastStoneSize = stone.size;
			// Destroy the object
			Destroy(stone.gameObject);
			// Activate the next layer of the stone stack
			Build();
		}
	}
	
	private void Build() {
		// Activate the next stone in the list to make it show up
		stones[stackSize].SetActive(true);
		// Increase the size of the stack
		stackSize += 1;
	}
}