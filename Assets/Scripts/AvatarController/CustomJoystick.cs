using CommandPattern;
using Lean.Touch;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[HelpURL(LeanTouch.HelpUrlPrefix + "LeanTouchEvents")]
[AddComponentMenu(LeanTouch.ComponentPathPrefix + "Touch Events")]
public class CustomJoystick
{
	private Vector3 initialTouchVector;
	private Vector3 currentTouchVector;
	private bool touchingTheScreen;

	public void OnEnable()
	{
		// Hook into the events we need
		touchingTheScreen = false;
		LeanTouch.OnFingerDown += HandleFingerDown;
		LeanTouch.OnFingerUpdate += HandleFingerUpdate;
		LeanTouch.OnFingerUp += HandleFingerUp;
		LeanTouch.OnFingerTap += HandleFingerTap;
		LeanTouch.OnFingerSwipe += HandleFingerSwipe;
		LeanTouch.OnGesture += HandleGesture;
	}

	public void OnDisable()
	{
		// Unhook the events
		LeanTouch.OnFingerDown -= HandleFingerDown;
		LeanTouch.OnFingerUpdate -= HandleFingerUpdate;
		LeanTouch.OnFingerUp -= HandleFingerUp;
		LeanTouch.OnFingerTap -= HandleFingerTap;
		LeanTouch.OnFingerSwipe -= HandleFingerSwipe;
		LeanTouch.OnGesture -= HandleGesture;
	}
	public Vector3 GetInitialTouchVector() {
		return initialTouchVector;
	}

	public Vector3 GetCurrentTouchVector()
	{
		return currentTouchVector;
	}

	public bool IsTouchingTheScreen()
	{
		return touchingTheScreen;
	}

	public Vector2 RotationAngle() {
		return MathUtils.CalcualteDirection(initialTouchVector, currentTouchVector);
	}

	public bool IsAbleToMove()
	{
		return  MathUtils.CalcualteDirection(initialTouchVector, currentTouchVector) != Vector2.zero;
	}

	public void HandleFingerDown(LeanFinger finger)
	{
		initialTouchVector = finger.ScreenPosition;
		currentTouchVector = finger.ScreenPosition;
		touchingTheScreen = true;
	}

	public void HandleFingerUpdate(LeanFinger finger)
	{
		currentTouchVector = (finger.ScreenPosition);
		touchingTheScreen = true;

	}


	public void HandleFingerUp(LeanFinger finger)
	{
		touchingTheScreen = false;

	}

	public void HandleFingerTap(LeanFinger finger)
	{
	}

	public void HandleFingerSwipe(LeanFinger finger)
	{
	}

	public void HandleGesture(List<LeanFinger> fingers)
	{
		/*Debug.Log("Gesture with " + fingers.Count + " finger(s)");
		Debug.Log("    pinch scale: " + LeanGesture.GetPinchScale(fingers));
		Debug.Log("    twist degrees: " + LeanGesture.GetTwistDegrees(fingers));
		Debug.Log("    twist radians: " + LeanGesture.GetTwistRadians(fingers));
		Debug.Log("    screen delta: " + LeanGesture.GetScreenDelta(fingers));*/
	}
}
