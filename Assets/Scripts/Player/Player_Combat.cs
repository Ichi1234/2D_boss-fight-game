using UnityEngine;

public class Player_Combat : Entity_Combat
{
    public override void PerformAttack(Collider2D targetCollision)
    {
        base.PerformAttack(targetCollision);

        if (isHitOpponent && IsOpponent(targetCollision))
        {
            KnockBackIfHitOpponent(currentAttackData);
        }
    }

    private void KnockBackIfHitOpponent(AttackData attackData)
    {
        Player player = GetComponent<Player>();
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

        if (player.isGround && attackData.playerAttackType == PlayerAttackTypes.Basic)
        {
            player.SetVelocity(attackData.knockback * -player.facingDir, rb.linearVelocity.y);
        }

        else if (attackData.playerAttackType == PlayerAttackTypes.Down)
        {
            player.SetVelocity(rb.linearVelocity.x, attackData.knockback);
        }
    }
}
