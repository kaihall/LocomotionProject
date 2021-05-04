using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// A rather simple way of working with the ObjectiveManager to keep the sign updated
public class ObjectiveText : MonoBehaviour
{
	public Objective objective;
	
	void Update() {
		GetComponent<TextMeshPro>().text = objective.objectiveText;
	}
}