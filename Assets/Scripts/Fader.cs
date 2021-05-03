using System;
using UnityEngine;

public class Fader : MonoBehavior
{
	private bool fadeOut = false;	// Is the object fading out right now?
	private bool fadeIn = false;	// Is the object fading in right now?
	public float fadeSpeed;			// Increase for faster fade
	
	void Update() {
		// If the object is fading out...
		if (fadeOut)
		{
			// Get its current color
			Color objectColor = GetComponent<Renderer>().material.color;
			// Adjust alpha based on fadeSpeed
			float newAlpha = objectColor.a - (fadeSpeed * Time.deltaTime);
			
			// Apply the new color
			objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, newAlpha);
			
			// If alpha is zero or negative, the object has completely faded out
			// Stop trying to make it fade
			if (objectColor.a <= 0)
				fadeOut = false;
		}
		
		// If the object is fading in...
		if (fadeIn)
		{
			// Get its current color
			Color objectColor = GetComponent<Renderer>().material.color;
			// Adjust alpha based on fadeSpeed
			float newAlpha = objectColor.a + (fadeSpeed * Time.deltaTime);
			
			// Apply the new color
			objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, newAlpha);
			
			// If alpha is 1 or more, the object has completely faded in
			// Stop trying to make it fade
			if (objectColor.a >= 1)
				fadeIn = false;
		}
	}
	
	public void FadeOut() {
		fadeOut = true;
	}
	
	public void FadeIn() {
		fadeIn = true;
	}
}