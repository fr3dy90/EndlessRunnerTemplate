using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SceneController _sceneController;
    [SerializeField] private LoaderController loaderController;
}

public enum Scenes
{
    Logo,
    Menu,
    GamePlay,
    LeaderBoard
}