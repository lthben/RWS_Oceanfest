using UnityEngine;

public class whale_controller : MonoBehaviour
{ 
    public Animator myAnimator;
    public AudioSource mySound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetBool("isWhaleActive", true);
            if (!mySound.isPlaying)
            {
                mySound.Play();
            }
        }
        else
        {
            myAnimator.SetBool("isWhaleActive", false);
        }
    }
}
