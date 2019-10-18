using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButtons : MonoBehaviour
{
    [SerializeField]
    AudioSource airport;

    [SerializeField]
    AudioSource gymnopedie;

    [SerializeField]
    AudioSource string_piece;

    [SerializeField]
    AudioSource your_call;

    private bool isPlaying;
    private bool airportPlaying;
    private bool gymnopediePlaying;
    private bool string_piecePlaying;
    private bool your_callPlaying; 

    

    private void Start()
    {
        isPlaying = false; 
    }

    void Update()
    {
        if (isPlaying)
        {
            if(airportPlaying && !airport.isPlaying)
            {
                skip(); 
            }
            if(gymnopediePlaying && !gymnopedie.isPlaying)
            {
                skip(); 
            }
            if(string_piecePlaying && !string_piece.isPlaying)
            {
                skip();
            }
            if(your_callPlaying && !your_call.isPlaying)
            {
                skip();
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (!isPlaying){
            airport.Play();
            isPlaying = true; 
        }
        else{
            skip(); 
        }
    }


    private void skip()
    {
        if (airport.isPlaying)
        {
            airport.Stop();
            gymnopedie.Play();
            airportPlaying = false; 
            gymnopediePlaying = true; 
        }
        else if (gymnopedie.isPlaying)
        {
            gymnopedie.Stop();
            string_piece.Play();
            gymnopediePlaying = false; 
            string_piecePlaying = true; 
        }
        else if (string_piece.isPlaying)
        {
            string_piece.Stop();
            your_call.Play();
            string_piecePlaying = false; 
            your_callPlaying = true; 
        }
        else
        {
            your_call.Stop();
            airport.Play();
            your_callPlaying = false; 
            airportPlaying = true; 
        }
        
    }

    public void turnOff()
    {
        airport.Stop();
        gymnopedie.Stop();
        string_piece.Stop();
        your_call.Stop(); 
        isPlaying = false;
        gymnopediePlaying = false;
        airportPlaying = false;
        your_callPlaying = false;
        string_piecePlaying = false; 
    }


}
