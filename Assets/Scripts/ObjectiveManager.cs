using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
	public List<Objective> objectives;
	
	void Start() {
		// Connect each objective to this manager
		foreach (Objective obj in objectives) {
			obj.objectiveManager = this;
		}
	}
	
	public void ClearObjective(Objective obj) {
		objectives.Remove(obj);
	}
}