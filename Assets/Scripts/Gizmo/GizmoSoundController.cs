using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;
using System;

public class GizmoSoundController : MonoBehaviour
{
    public EventReference iddleSound;
    public EventReference moveSound;
    public EventReference takeDamageSound;
    public EventReference jumpSound;


    private EventInstance iddleSoundInstance;
    private EventInstance moveSoundInstance;
    private EventInstance takeDamageSoundInstance;
    private EventInstance jumpSoundInstance;

    void Awake()
    {
        iddleSoundInstance = RuntimeManager.CreateInstance(iddleSound);
        moveSoundInstance = RuntimeManager.CreateInstance(moveSound);
        takeDamageSoundInstance = RuntimeManager.CreateInstance(takeDamageSound);
        jumpSoundInstance = RuntimeManager.CreateInstance(jumpSound);

        MovedOrStopped(false);
    }

    public void MovedOrStopped(bool isMoving)
    {
        stopAllSounds();
        if (isMoving)
        {
            moveSoundInstance.start();
        }
        else
        {
            iddleSoundInstance.start();
        }
    }

    public void TakeDamage()
    {
        stopAllSounds();
        takeDamageSoundInstance.start();
    }

    public void jump()
    {
        stopAllSounds();
        jumpSoundInstance.start();
    }

    public void stopAllSounds()
    {
        iddleSoundInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        moveSoundInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        takeDamageSoundInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        jumpSoundInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
    }

}
