using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    class DNShotgun : Shotgun {
        public DNShotgun(float xval, float yval) : base(xval, yval) {
            this._ammoType = new ATShotgun();
            this._ammoType.range = 128f;
            this._ammoType.rangeVariation = 32f;
            this._barrelOffsetTL = new Vec2(28f, 3f);
            this._bio = "Packs a far more powerful blast than the pistol.";
            this._editorName = "Shotgun";
            this._fireSound = GetPath("sounds/shotgun.wav");
            this._fullAuto = false;
            this._fireWait = 7f;
            this._numBulletsPerFire = 7;
            this.ammo = 10;
            this.center = new Vec2(8f, 5f);
            this.collisionOffset = new Vec2(-12f, -3f);
            this.collisionSize = new Vec2(32f, 9f);
            this.graphic = new SpriteMap(GetPath("sprites/ShotgunSprite.png"), 28, 12);
            this._loaderSprite = new SpriteMap(GetPath("sprites/ShotgunPumpSprite.png"), 7, 7);
            this._loaderSprite.center = new Vec2(-1f, 4f);
            this.loseAccuracy = 0.3f;
            this.maxAccuracyLost = 0.9f;
        }
    }
}
