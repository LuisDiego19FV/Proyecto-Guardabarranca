using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class Movementx
    {
        private GameObject controls;
        private GameObject joystick;
        private GameObject handle;
        private GameObject player;

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator MovementxWithEnumeratorPasses()
        {
            SceneManager.LoadScene("Finca");

            yield return new WaitForSeconds(4);

            // This gets the GameObject named handel
            controls = GameObject.Find("Controls");
            joystick = controls.transform.GetChild(0).gameObject;
            handle = joystick.transform.GetChild(0).gameObject;

            // Gests player
            player = GameObject.Find("Player");


            Vector3 player_original_pos = player.transform.position;

            //Move player using joystick handle
            handle.transform.position = new Vector3(handle.transform.position.x, 100, handle.transform.position.z);

            yield return new WaitForSeconds(0.5f);

            Vector3 player_new_pos = player.transform.position;

            yield return null;


            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return new WaitForSeconds(0.5f);

            Assert.False(player_new_pos == player_original_pos);
        }
    }
}
