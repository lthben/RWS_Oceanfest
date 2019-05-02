using UnityEngine;

public class herring_controller : MonoBehaviour
{ 
    public Animator myAnimator;
    public AudioSource mySound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            myAnimator.SetBool("isHerringActive", true);
            if (!mySound.isPlaying)
            {
                mySound.Play();
            }
        }
        else
        {
            myAnimator.SetBool("isHerringActive", false);
        }
    }
}
