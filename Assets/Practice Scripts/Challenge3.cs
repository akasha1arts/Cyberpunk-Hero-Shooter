using UnityEngine;

namespace Challenges
{
    public static class Challenge3
    {
        /// <summary>
        /// Please implement this method that will place a camera in front of an object
        /// such that the camera can see the entire object and the object is centered on the screen.
        /// 
        /// Pre-Conditions:
        ///     myCamera is the main camera, rendering to the screen
        /// 
        /// Post-Conditions:
        ///     myCamera's up vector is equal to Vector3.Up (world up vector)
        ///     myCamera's forward vector is equal to -target.transform.forward (camera is looking at the front of the object)
        ///     myCamera's position has been adjusted so that the entirety of target is visible on-screen and is centered.
        ///     myCamera's field of view is unchanged.
        ///
        /// Cases to consider:
        ///     the object is very tall: dimensions = (1, 100, 1)
        ///     the object is very wide: dimensions = (100, 1, 1)
        ///     the object is very deep: dimensions = (1, 1, 100)
        /// 
        /// </summary>
        public static void PlaceCameraToSeeWholeObject(Camera myCamera, MeshRenderer target)
        {
            myCamera.transform.position = target.transform.position;
            

        }
    }
}