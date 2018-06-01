using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpEvent : Event {

    private Level level;

    public LevelUpEvent(Level level) : base("level_up") {
        this.level = level;
    }

    public Level getLevel() {
        return this.level;
    }

}
