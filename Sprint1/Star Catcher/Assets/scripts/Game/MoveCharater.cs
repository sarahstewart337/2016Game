using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveCharater : MonoBehaviour
{
    private int count;
    public Text Score;
    
        // this is the character controller component
    public CharacterController myCC;
    //temp var of data type vector3 to move the character
    private Vector3 tempPos;
    //speed of temp car in x
    public float Speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    //Sliding vars
    public int slideDuration = 100;
    public float slideTime = 0.01f;

    private bool crash = true;

    private AudioSource audio;

    public AudioClip[] audioClip;

    //Coroutine for Sliding Character
    IEnumerator Slide ()
    {
        //set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float newSpeedTemp = Speed;
        Speed +=Speed;
        //while loops will run until true and then stop/ While loop runs while the slideDuration is greater than 0
        while (slideDuration > 0)
        {
            //subtracts 1 from the slide duration
            slideDuration--;
            //yield "holds the coroutine"
            //return sends to the coroutine to do an operation while yielding
            // new creates an instance of an object
            //waitforseconds is an object that waits for a duration of time
            yield return new WaitForSeconds(slideTime);
            
        }
        slideDuration = durationTemp;
    }


   
    // Use this for initialization
    void Start ()
    {
        audio = GetComponent<AudioSource>();
        //This "Finds" the charaacter controller component
        myCC = GetComponent<CharacterController>();
        count = 0;
        SetCountCountText();


    }
	
	// Update is called once per frame
	void Update ()
    {
        //waiting for input and comparing jumpCount
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount <= jumpCountMax-1)
        {
            //incrementing the jump count by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }

        //Start Sliding
        if(Input.GetKey(KeyCode.RightArrow)&& Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());
        }
        // test if character controller is grounded
        if (myCC.isGrounded)
        {
            // reset jump count if grounded
            jumpCount = 0;
        }
       
       

        // adding the gravity var to the y position of the tempPos var
        tempPos.y -= gravity * Time.deltaTime;
        //adding the speed var to the tempPos var x value with the right and left arrow keys
        tempPos.x = Speed*Input.GetAxis("Horizontal");
        //moves the character controller at an even pace
        myCC.Move(tempPos * Time.deltaTime);
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("star"))
        {
            Destroy(other.gameObject);
            count = count + 1;
            SetCountCountText();
            PlaySound(0);
        }

        if (other.gameObject.CompareTag("crash")&& crash)
        {
            count = count / 2;
            SetCountCountText();
            crash = false;
            PlaySound(1);
        }
    }

    void PlaySound(int clip)
    {
        audio.PlayOneShot(audioClip[clip]);
    }
    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("crash")&& !crash)
        {
            crash = true;
        }
    }
    void SetCountCountText ()
    {
        Score.text = "Score: " + count.ToString();
    }


}

