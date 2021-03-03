using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//Gia Khanh's code
public class CharacterMovement : MonoBehaviour
{
    MyInput myInput;
    // Start is called before the first frame update
    [SerializeField] private float movementSpeed; //Hero's speed
    private Vector2 direction = new Vector2(); // Hero's direction
    Rigidbody2D rb2d; //Reference to the hero's rigid body
    Animator anim; //Reference to the hero's animator

    private bool isAttacking;
    public float attackSpeed;
    private float attackCooldown;


    void Start()
    {
        myInput = new MyInput();
        rb2d = GetComponent<Rigidbody2D>(); //Cache the rigid body component
        anim = GetComponent<Animator>(); //Cache the rigid body component
    }
    

    public void PlayerInput(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>(); //new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //GetAxisRaw to prevent the hero to slide after release the button
         
    }
    public void AttackInput(InputAction.CallbackContext context)
    {
        isAttacking = context.performed;
        myInput.Player.Attack.performed += ctx => Attack();
    }

    private void Move() 
    {
        //Vector2 heroPosition = new Vector2();
        //heroPosition += direction.normalized  * movementSpeed * Time.fixedDeltaTime;
        //rb2d.velocity = heroPosition;  //Method 1

        //Normalized to prevent hero from moving faster when pressing two directional keys at the same time.
        //fixedDeltatime works well with fixedUpdate, which is ideal for Physics
        rb2d.velocity = new Vector2(direction.normalized.x * movementSpeed * Time.fixedDeltaTime, direction.normalized.y * movementSpeed * Time.fixedDeltaTime); //Method 2   
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            rb2d.velocity = Vector2.zero; //Stop the hero from moving when attacking
            attackCooldown = attackSpeed;
            anim.SetBool("isAttacking", true);
            isAttacking = true;
        }

        if (attackCooldown > 0) //After performing an attack, wait for an amount of second before able to perform another attack.
        {
            attackCooldown -= Time.deltaTime;
        }
        else 
        {
            isAttacking = false;
            anim.SetBool("isAttacking", false);
        }
    }
    private void HeroAnimation()
    {
        anim.SetFloat("Horizontal", direction.x);
        anim.SetFloat("Vertical", direction.y);
        anim.SetFloat("Magnitude", rb2d.velocity.magnitude);
        
        //   //Check the last move of the hero and set the idle animation to fit to that direction
        //if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        //{
        //    anim.SetFloat("LastHorizontalMove", Input.GetAxisRaw("Horizontal"));
        //    anim.SetFloat("LastVerticalMove", Input.GetAxisRaw("Vertical"));
        //}        
    }
    // Update is called once per frame
    void Update()
    {
        Attack(); // In the FixedUpdate, the animations get delayed.
        //PlayerInput();
    }
    private void FixedUpdate()
    {
        if (!isAttacking)
        {
            HeroAnimation();
            Move();
        }
    }
}
