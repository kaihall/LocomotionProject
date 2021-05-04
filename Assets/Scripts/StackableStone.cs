using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackableStone : MonoBehaviour
{
	public int size;				// The stone's size. Can be 1-5 (5 is largest, 1 is smallest)
	internal bool held = false;		// Whether the stone is currently being held
}