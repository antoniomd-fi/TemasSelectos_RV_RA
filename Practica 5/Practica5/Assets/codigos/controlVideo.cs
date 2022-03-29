using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class controlVideo : MonoBehaviour
{
    public VideoPlayer video360;
    public GameObject botonPlay;
    // Start is called before the first frame update
    public void  play() {
        video360.Play();
        botonPlay.SetActive(false);
    }
}
