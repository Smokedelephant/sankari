namespace MarioLikeGame;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager manager)
    {
        GD.Print("Idle");
    }

    public override void UpdateState(PlayerStateManager manager)
    {
        if (manager.IsMoving())
            manager.SwitchState(manager.PlayerMovingState);

        if (manager.IsJumping())
            manager.SwitchState(manager.PlayerJumpingState);

        if (manager.IsFalling())
            manager.SwitchState(manager.PlayerFallingState);
    }

    public override void OnAreaEntered(PlayerStateManager manager, Area2D area)
    {
        
    }
}