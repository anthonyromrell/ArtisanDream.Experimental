using System;
using System.Collections;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public bool check;
    private bool OtherCheck;
    private bool OtherOtherCheck;
    private bool OtherOtherOtherCheck;

    public int GameNum;

    public enum GameStates 
    {
        Playing,
        Starting,
        Ending
    }
    
    public enum WeaponState 
    {
        Hold,
        Fire,
        Lock
    }

    public WeaponState currentWeaponState = WeaponState.Lock;

    public GameStates currentGameState = GameStates.Starting;
    
    private void Start()
    {
        if (check)
        {
           //Do Work 
        }
        else if (OtherCheck)
        { 
            // Do Other Work
        }
        else if (OtherOtherCheck)
        {
            // Do Other Other Work
        }
        else if (OtherOtherOtherCheck)
        {
            // Do Other Other Work
        }
        else
        {
            // Do Other Other Work
        }

        switch (currentGameState)
        {
            case GameStates.Starting:
                //Do Work
                currentGameState = GameStates.Playing;
                break;
            
            case GameStates.Playing:
                
                currentGameState = GameStates.Playing;
                //Do Work
                break;
            
            case GameStates.Ending:
                //Do Work
                break;
            
            default:
                //Do This;
                break;
        }

        switch (GameNum)
        {
            case 1:
                //Do Work
                break;
            case 2:
                //Do Work
                break;
            case 3:
                //Do Work
                break;
            case 4:
                //Do Work
                break;
            case 5:
                //Do Work
                break;
            default:
                //Reset;
                break;
            
        }

        switch (currentWeaponState)
        {
            case WeaponState.Hold:
                //
                break;
            case WeaponState.Fire:
                //
                break;
            case WeaponState.Lock:
                //
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
}
