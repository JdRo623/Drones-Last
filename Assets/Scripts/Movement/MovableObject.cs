using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    public float movementSpeed;

    //These methods will be executed by their own command
    public void MoveForward()
    {
        Move(Vector3.forward);
    }

    public void MoveBack()
    {
        Move(Vector3.back);
    }

    public void TurnLeft()
    {
        Move(Vector3.left);
    }

    public void TurnRight()
    {
        Move(Vector3.right);
    }

    private void Move(Vector3 dir)
    {
        transform.Translate(dir * movementSpeed * Time.deltaTime);
    }

    public void Rotate(Vector2 rotationAngle)
    {
        Vector3 moveDirection = new Vector3(rotationAngle.x, 0, rotationAngle.y);
        Quaternion targetRotation = moveDirection != Vector3.zero ? Quaternion.LookRotation(moveDirection) : transform.rotation;
        transform.rotation = targetRotation;
    }
}
