using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMovement : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;
    [SerializeField] public float finalSpeed = 0;
    float normalSpeed;
    float speedUpSpeed;
    public float initialSpeed;
    public CharacterController controller;
    public float currSpeed;
    Vector3 lastPos;
    Vector3 posInicial;
    bool speedUpMejora;
    float timeToStopSpeedUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            print("AXIS1");
            transform.eulerAngles = new Vector3(0, Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * 180 / Mathf.PI, 0);

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection *= initialSpeed * Time.deltaTime;
            print(moveDirection);
            // moveDirection = transform.TransformDirection(Vector3.forward) * initialSpeed;
            controller.Move(moveDirection);

        }
        PlayerPrefs.SetString("TransformX", (transform.position.x).ToString());
        PlayerPrefs.SetString("TransformZ", (transform.position.z).ToString());
        PlayerPrefs.SetString("RotationY", (transform.eulerAngles.y).ToString());
    }
}
