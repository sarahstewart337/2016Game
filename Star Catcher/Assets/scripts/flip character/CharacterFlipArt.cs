using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour
{
    public Transform  characterArt;
    public bool forward = true;

    void FlipCharacter(KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.RightArrow:
                if (forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    break;

                    forward = false;
                }
                

            case KeyCode.LeftArrow:
                if (!forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    break;

                    forward = true;
                }
                break;
        }
       
      //  forward = _b;

    }


	// Use this for initialization
	void Start ()
    {
        UserInputs.UserInput += FlipCharacter;

	
	}
	
	// Update is called once per frame
	void Update ()
    {

	
	}
}
