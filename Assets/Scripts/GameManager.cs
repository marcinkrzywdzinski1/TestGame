using UnityEngine;

namespace TestGame
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private int targetFrameRate = 60;

        private void Awake()
        {
            Application.targetFrameRate = targetFrameRate;
        }

        private void Start()
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}
