﻿using CommandPattern;
using CommandPattern.Commands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    public MovableObject movableObject;
    private CustomJoystick customJoystick;

    private Command touchingScreen;
    private CommandParam movingJoystick;
    private Command enemyDetection;
    private Command doubleTouch;
    // Start is called before the first frame update
    void Start()
    {
        touchingScreen = new MoveFowardCommand(movableObject);
        movingJoystick = new RotateCommand(movableObject);
        enemyDetection = new ShootCommand();
        doubleTouch = new NoActionCommand();
    }

    protected virtual void OnEnable()
    {
        customJoystick = new CustomJoystick();
        customJoystick.OnEnable();

    }

    protected virtual void OnDisable()
    {
        customJoystick.OnDisable();
    }

    // Update is called once per frame
    void Update()
    {
        if (customJoystick.IsTouchingTheScreen()&& customJoystick.IsAbleToMove())
        {
            ExecuteNewCommand(touchingScreen);
            ExecuteNewCommandParam(movingJoystick, customJoystick.RotationAngle());
            ExecuteNewCommand(enemyDetection);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            ExecuteNewCommand(enemyDetection);
        }
    }

    public void DoubleTap(int taps) {
        print(taps);
        if (taps>=2) { 
           if (touchingScreen is MoveFowardCommand)
           {
              touchingScreen = new MoveBackCommand(movableObject);
           }
           else{
              touchingScreen = new MoveFowardCommand(movableObject);
            }
        }
    }

    private void ExecuteNewCommand(Command commandButton)
    {
        commandButton.Execute();
    }

    private void ExecuteNewCommandParam(CommandParam commandButton, Vector2 reference)
    {
        commandButton.Execute(reference);
    }
}
