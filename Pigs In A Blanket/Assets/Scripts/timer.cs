using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class timer : MonoBehaviour {
	public Text timerLabel;

	private float time;
	private float timeRemaining;
	private float allowedTime = 255;
	private int allowedMinutes = 255 / 60;
	void Update() {
		time += Time.deltaTime;
		allowedTime -= Time.deltaTime;
		var minutesRemaining = allowedMinutes - (allowedMinutes - (allowedTime / 60));
		var secondsRemaining = allowedTime % 60;

		//update the label value
		if (secondsRemaining > 10)
			timerLabel.text = string.Format("Time: {0,1:F0} : {1,2:F2}", Math.Ceiling(minutesRemaining) - 1, secondsRemaining);
		else
			timerLabel.text = string.Format("Time: {0,1:F0} : 0{1,2:F2}", Math.Ceiling(minutesRemaining) - 1, secondsRemaining);
	}
}
