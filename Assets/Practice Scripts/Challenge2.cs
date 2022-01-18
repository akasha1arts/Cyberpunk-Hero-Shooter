using UnityEngine;

namespace Challenges
{
    public class Challenge2 : MonoBehaviour
    {
        public MeshRenderer pillar;
    
        /// <summary>
        /// Finish this code to create a square grid of pillars in the XZ (right x forward) plane, each with a random color, as described below.
        /// 
        /// Post-Conditions:
        ///     - numPillarsPerRow^2 pillars have been created as children of this object in a
        ///       square grid pattern on the XZ plane with 'gridSpacing' meters in between each.
        ///     - Each pillar has a random color
        /// 
        ///     - Bonus: if this method gets called first with numPillarsPerRow = 10, then with numPillarsPerRow = 6,
        ///       no pillars are destroyed and exactly 100 pillars are instantiated
        /// </summary>
        public void CreateGrid(int numPillarsPerRow, float gridSpacing)
        {
            
        }
    }
}