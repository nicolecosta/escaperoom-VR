using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Controle : MonoBehaviour
{
    public bool ShowController = false;

    public bool ShowHand = false;


    void Update()

    {

        for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)

        {

            Hand hand = Player.instance.hands[handIndex];

            if (hand != null)

            {

                if(ShowController) {

                    hand.ShowController(true);

                    // Faz a pose da mão encaixar no controle

                    hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController);


                } else {

                    hand.HideController(true);

                    // Faz a pose da mão ficar como se não segurasse nada

                    hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);

                }

                if(ShowHand) {

                    hand.ShowSkeleton(true);

                } else {

                    hand.HideSkeleton(true);

                }

            }

        }

    }   
}
