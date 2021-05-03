using System;
using UnityEngine;

public class StackableStone : MonoBehavior
{
	public int size;				// The stone's size. Can be 1-5 (5 is largest, 1 is smallest)
	internal bool held = false;		// Whether the stone is currently being held
}