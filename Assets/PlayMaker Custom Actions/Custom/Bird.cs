using UnityEngine;
using HutongGames.PlayMaker;

public class ParticleTrigger : MonoBehaviour
{
    public string playmakerEvent = "OnParticleCollision"; // PlayMaker에서 사용할 이벤트 이름

    public PlayMakerFSM fsm;

    void Start()
    {
        fsm = GetComponent<PlayMakerFSM>();

        if (fsm == null)
        {
            Debug.LogError("No PlayMakerFSM component found on this object! Disabling script.");
            enabled = false; // PlayMakerFSM이 없으면 스크립트 비활성화
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (fsm != null && other != null)
        {
            // PlayMaker FSM에 이벤트를 보내면서 충돌한 오브젝트 데이터를 포함
            FsmEventData eventData = new FsmEventData();
            eventData.GameObjectData = other;
            Fsm.EventData = eventData;  // PlayMaker 이벤트 데이터 설정
            fsm.SendEvent(playmakerEvent);  // 이벤트 전송

            Debug.Log($"Particle collided with {other.name}, sending event '{playmakerEvent}' with object data");
        }
    }
}
