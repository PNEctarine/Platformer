using DG.Tweening;
using UnityEngine;

public class ObstaclePlatformComponent : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _platformSpeed;
    [SerializeField] private Transform[] _wayPoints;

    private Vector3[] _wayPointsPosition;
    private int _currentWayPoint;

    private void Start()
    {
        _wayPointsPosition = new Vector3[_wayPoints.Length];

        for (int i = 0; i < _wayPoints.Length; i++)
        {
            _wayPointsPosition[i] = _wayPoints[i].position;
        }
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(_wayPoints[_currentWayPoint].position, _rigidbody.position) <= 0)
        {
            _currentWayPoint++;

            if (_currentWayPoint >= _wayPoints.Length)
            {
                _currentWayPoint = 0;
            }

            _rigidbody.DOMove(_wayPoints[_currentWayPoint].position, _platformSpeed).SetUpdate(UpdateType.Fixed).SetUpdate(UpdateType.Fixed);
        }
    }
}
