using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{   private bool CanMove = true;
    [SerializeField]  Rigidbody rb;
    [SerializeField]  Animator animator;
    [SerializeField]  Avatar avatar;

    // Start is called before the first frame update
    void Start()
    {   
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();    
    }
    public float RotationSpeed = 5.0f;
    public float Speed = 0.1f;
  
    void Update()
    {   
        if (CanMove){
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 direction = new Vector3(horizontalInput, 0, verticalInput)*Speed*Time.deltaTime;
            transform.Translate(direction);

            float horizontalRotation = Input.GetAxis("Horizontal");
            float rotationAngle = horizontalRotation * RotationSpeed;
            Quaternion rotation = Quaternion.Euler(0,rotationAngle,0);
            transform.Rotate(rotation.eulerAngles);

            float movementMagnitude = direction.magnitude;
            
            
            if (movementMagnitude > 0.0001f){
                animator.SetBool("Run", true);
            }else{
                animator.SetBool("Run", false);
            }}
            if(animator.GetCurrentAnimatorStateInfo(0).IsName("Dead"))
            {
                CanMove = false;
            }
            else
            {
                CanMove = true;
            }
            }
        
    }


