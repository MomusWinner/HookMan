using UnityEngine;

namespace ECS.Game
{
    public class GameControllerBehaviour : MonoBehaviour
    {
        private GameController _gameController;

        private void Awake() => _gameController = new GameController(Contexts.sharedInstance);

        private void Start() => _gameController.Initialize();

        private void Update() => _gameController.Execute();
    }
}