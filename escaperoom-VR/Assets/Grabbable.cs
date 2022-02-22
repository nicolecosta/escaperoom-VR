using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using Valve.VR.InteractionSystem;


public class Grabbable : Valve.VR.InteractionSystem.Throwable {

   

    private int bloqueado;


    protected override void HandHoverUpdate(Hand hand) {

        GrabTypes startingGrabType = hand.GetGrabStarting();

        if (startingGrabType != GrabTypes.None)

        {

            hand.AttachObject(gameObject, startingGrabType, attachmentFlags, attachmentOffset);

        }

        if (startingGrabType == GrabTypes.Grip) bloqueado = 2;

        else bloqueado = 0;

    }



    protected override void HandAttachedUpdate(Hand hand) {

        if (hand.IsGrabEnding(this.gameObject) && (bloqueado<=0))

            hand.DetachObject(gameObject, restoreOriginalParent);

        if (hand.GetGrabEnding(GrabTypes.Grip) == GrabTypes.Grip)

            bloqueado -= 1;

    }

}