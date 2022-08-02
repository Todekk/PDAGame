
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class GladiatorController : MonoBehaviour {


    SpriteRenderer Srend;
    Animator anim;


    //change these variables if you wish to test different speeds and jump heights
    [SerializeField]
    float moveForce = .1f;


    //this variable is used for the screen wrapping
    float screenHalfWidthInWorldUnits;

    bool screenWrap = false;



    void Start()
    {
        Srend = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();

        //these lines are used to calculate screen wrapping
        float halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;
    }
    // Update is called once per frame
    void Update () {
        //controller and sprite manipulation
        #region
        //controller and sprite manipulation
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("WalkUp", true);

            transform.Translate(Vector2.up * Time.fixedDeltaTime);
         
            anim.SetBool("Idle", false);
        }else
        {
            anim.SetBool("WalkUp", false);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("WalkRight", true);
            transform.Translate(Vector2.right * Time.fixedDeltaTime);
            anim.SetBool("Idle", false);
        }
        else
        {
            anim.SetBool("WalkRight", false);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("WalkLeft", true);
            transform.Translate(Vector2.left * Time.fixedDeltaTime);

        }
else        {
            anim.SetBool("WalkLeft", false);

        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("WalkDown", true);

            transform.Translate(Vector2.down * Time.fixedDeltaTime);

        }
        else
        {
            anim.SetBool("WalkDown", false);
        }



       

        if (Input.GetKeyDown(KeyCode.Space))
        {

            anim.SetBool("Idle", false);

        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.SetBool("Die", true);
            anim.SetTrigger("Death");
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
       
        }
        #endregion // //controls and sprite manipulation


        //camera wrap
        #region
        //controls the camera wrap
        if (screenWrap)
        {


            if (transform.position.x < -screenHalfWidthInWorldUnits)
            {
                transform.position = new Vector2(screenHalfWidthInWorldUnits, transform.position.y);
            }

            if (transform.position.x > screenHalfWidthInWorldUnits)
            {
                transform.position = new Vector2(-screenHalfWidthInWorldUnits, transform.position.y);
            }
        }
        #endregion//camera wrap 
    }
}

