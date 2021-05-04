using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLantern : MonoBehaviour
{
    internal Objective objective;
	
	void Start() {
		objective = GetComponent<Objective>();
	}
}
