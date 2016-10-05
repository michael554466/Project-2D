using UnityEngine;
using System.Collections;

public class CharicterJoystickControler : MonoBehaviour {


    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;
    private float sprintSpeed;
    public float Speed = 25;
    public float Agility = 25;
    public EasyJoystick moveJoy;
    public Vector3 joystick;
    void Start()
    {

        walkSpeed = (float)(Speed + (Agility / 5));
        sprintSpeed = walkSpeed + (walkSpeed / 2);

    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;
        maxSpeed = curSpeed;

        joystick = moveJoy.MoveInput();
        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, joystick.x * curSpeed, 0.8f),
                                             Mathf.Lerp(0, joystick.z * curSpeed, 0.8f));
    }
}
