using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyMessageListener : MonoBehaviour
{

    public Animator myAnimator1;
    public AudioSource mySound1;
    public Animator myAnimator2;
    public AudioSource mySound2;
    public Animator myAnimator3;
    public AudioSource mySound3;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (myAnimator1.GetCurrentAnimatorStateInfo(0).IsName("dolphin_motion") && myAnimator1.GetBool("isDolphinActive") == true) 
        {
            myAnimator1.SetBool("isDolphinActive", false);
        }
        if (myAnimator2.GetCurrentAnimatorStateInfo(0).IsName("herring_motion") && myAnimator2.GetBool("isHerringActive") == true)
        {
            myAnimator2.SetBool("isHerringActive", false);
        }
        if (myAnimator3.GetCurrentAnimatorStateInfo(0).IsName("whale_motion") && myAnimator3.GetBool("isWhaleActive") == true)
        {
            myAnimator3.SetBool("isWhaleActive", false);
        }

    }
    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
        if (msg == "d")
        {
            myAnimator1.SetBool("isDolphinActive", true);
            if (!mySound1.isPlaying)
            {
                mySound1.Play();
            }
        }
        else if (msg == "h")
        {
            myAnimator2.SetBool("isHerringActive", true);
            if (!mySound2.isPlaying)
            {
                mySound2.Play();
            }
        }
        else if (msg == "w")
        {
            myAnimator3.SetBool("isWhaleActive", true);
            if (!mySound3.isPlaying)
            {
                mySound3.Play();
            }
        }
    }
    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}