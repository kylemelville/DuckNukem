using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    class DNShotgun : Shotgun {
        public DNShotgun(float xval, float yval) : base(xval, yval) {
            this._type = "gun";
            this._editorName = "Shotgun";
            this._bio = "Packs a far more powerful blast than the pistol.";
            this._fireSound = GetPath("sounds/DNShotgun.wav");
            this.graphic = new Sprite(GetPath("sprites/DNShotgun.png"));
            this._loaderSprite = new SpriteMap(GetPath("sprites/DNShotgunPump.png"), 7, 7);
            this._loaderSprite.center = new Vec2(5f, 5f);
            this._ammoType = new ATShotgun();
            this._ammoType.range = 140f;
            this._ammoType.rangeVariation = 16f;
            this.ammo = 10;
            this._manualLoad = true;
            this._fireWait = 7f;
            this._numBulletsPerFire = 7;
            this._kickForce = 5f;           
            this._barrelOffsetTL = new Vec2(28f, 3f);
            this.center = new Vec2(this.graphic.width / 2, this.graphic.height / 2);
            this.collisionOffset = -1 * this.center;
            this.collisionSize = new Vec2(this.graphic.width, this.graphic.height);
            this.handOffset = new Vec2(0f, 1f);
            this._holdOffset = new Vec2(5f, 2f);
        }
    }
}
