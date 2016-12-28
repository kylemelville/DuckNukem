using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckGame;

namespace DuckNukem.src
{
    [EditorGroup("Duck Nukem")]
    class DNShotgun : Shotgun
    {
        public DNShotgun(float xval, float yval) : base(xval, yval)
        {
            
            _ammoType = new ATShotgun();
            _barrelOffsetTL = new Vec2(34f, 3f); 
            _bio = "Packs a far more powerful blast than the pistol.";
            _editorName = "Shotgun";
            _fireSound = GetPath("sounds/shotgun.wav");
            _fullAuto = false;
            _fireWait = 2f;
            //_kickForce = 3.5f;
            _numBulletsPerFire = 5;
            ammo = 20;
            center = new Vec2(14f, 5f);
            collisionOffset = new Vec2(-12f, -3f);
            collisionSize = new Vec2(32f, 9f);
            graphic = new SpriteMap(GetPath("sprites/ShotgunSprite.png"), 28, 12, false);
            loseAccuracy = 0.3f;
            maxAccuracyLost = 0.9f;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void OnPressAction()
        {
            base.OnPressAction();
            //if (this.ammo > 0)
            //{
            //    this._sprite.AddAnimation(("gfire" + ammo), 0.1f, false, new int[] { 1, 0 });
            //    this._sprite.SetAnimation("gfire" + ammo);
            //}
            //else
            //{
            //    this._sprite.SetAnimation("empty");
            //}
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
