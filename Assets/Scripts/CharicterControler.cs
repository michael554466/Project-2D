using UnityEngine;
using System.Collections;

public class CharicterControler : MonoBehaviour {


    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;
    private float sprintSpeed;
    public float Speed = 25;
    public float Agility = 25;

    void Start()
    {

        walkSpeed = (float)(Speed + (Agility / 5));
        sprintSpeed = walkSpeed + (walkSpeed / 2);

    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;
        maxSpeed = curSpeed + (curSpeed / 2);


        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
                                             Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
    }
}
