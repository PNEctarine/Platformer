using Kuhpik;
using UnityEngine;

public class PlayerInputSystem : GameSystemWithScreen<GameUIScreen>, IIniting, IFixedUpdating
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Vector3 _playerDirection;
    private Animator _animator;

    private const string _animatorParameter = "State";

    void IIniting.OnInit()
    {
        screen.JumpButton.onClick.AddListener(() => PlayerJumping());
        _animator = game.PlayerRB.GetComponentInChildren<Animator>();
    }

    void IFixedUpdating.OnFixedUpdate()
    {
        if (screen.FixedJoystick.Direction.magnitude > 0)
        {
            _playerDirection = new Vector3(screen.FixedJoystick.Horizontal * _speed, game.PlayerRB.velocity.y, screen.FixedJoystick.Vertical * _speed);
            game.PlayerRB.velocity = _playerDirection;

            if (screen.FixedJoystick.Direction.magnitude > 0.5)
            {
                _animator.SetInteger(_animatorParameter, 2);
            }

            else
            {
                _animator.SetInteger(_animatorParameter, 1);
            }

        }

        else
        {
            game.PlayerRB.velocity = new Vector3(0, game.PlayerRB.velocity.y, 0);
            _animator.SetInteger(_animatorParameter, 0);
        }

        float angle = Mathf.Atan2(_playerDirection.x, _playerDirection.z) * Mathf.Rad2Deg;
        game.PlayerRB.rotation = Quaternion.Euler(0, angle, 0);
    }

    private void PlayerJumping()
    {
        game.PlayerRB.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        _animator.SetInteger(_animatorParameter, 3);
    }
}
