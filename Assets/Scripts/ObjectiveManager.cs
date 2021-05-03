using System;
using UnityEngine;

public class ObjectiveManager : MonoBehavior
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