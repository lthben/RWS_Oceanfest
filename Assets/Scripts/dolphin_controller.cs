using UnityEngine;

public class dolphin_controller : MonoBehaviour
{ 
    public Animator myAnimator;
    public AudioSource mySound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            myAnimator.SetBool("isDolphinActive", true);
            if (!mySound.isPlaying)
            {
                mySound.Play();
            }
        }
        else
        {
            myAnimator.SetBool("isDolphinActive", false);
        }
    }
}
