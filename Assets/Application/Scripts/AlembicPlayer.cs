using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UTJ.Alembic;

public class AlembicPlayer : MonoBehaviour
{
    [SerializeField] private AlembicStreamPlayer _alembicStreamPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _alembicStreamPlayer.currentTime += Time.deltaTime;
        if (_alembicStreamPlayer.currentTime > 3)
            _alembicStreamPlayer.currentTime = 0;
    }
}
