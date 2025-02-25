﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Note : MonoBehaviour
{

    public Image Noteimage;
    public GameObject NoteSentencesText;

    public AudioClip pickupSound;

    public GameObject playerobject;
    [HideInInspector] public bool IsNoteCollected;

    // Start is called before the first frame update
    void Start()
    {
        Noteimage.enabled = false;
        NoteSentencesText.SetActive(false);
        IsNoteCollected = false;
    }

    public void ShowNoteImage()
    {
        Noteimage.enabled = true;
        NoteSentencesText.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        playerobject.GetComponent<FirstPersonController>().enabled = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideNoteImage()
    {
        Noteimage.enabled = false;
        NoteSentencesText.SetActive(false);
        GetComponent<AudioSource>().PlayOneShot(pickupSound);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerobject.GetComponent<FirstPersonController>().enabled = true;
    }
}
