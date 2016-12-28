using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DuckGame;

namespace DuckNukem.src
{
    [EditorGroup("Duck Nukem")]
    public class DNPistol : Gun
    {
        SpriteMap _sprite;

        public DNPistol(float xval, float yval) : base(xval, yval)
        {
            _ammoType = new AT9mm();
            _barrelOffsetTL = new Vec2(17f, 3f);
            _bio = "You should probably find something better.";
            _editorName = "Pistol";
            _fireSound = GetPath("sounds/pistol.wav");
            _fullAuto = false;
            _fireWait = 1f;
            _sprite = new SpriteMap(GetPath("sprites/PistolSprite.png"), 16, 10, false);            
            _sprite.AddAnimation("empty", 0.1f, false, new int[] { 1 });
            ammo = 12;
            center = new Vec2(10f, 4f);
            collisionOffset = new Vec2(-9f, -6f);
            collisionSize = new Vec2(16f, 11f);
            graphic = _sprite;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void OnPressAction()
        {
            base.OnPressAction();
            if(this.ammo > 0)
            {
                this._sprite.AddAnimation(("gfire" + ammo ), 0.1f, false, new int[] { 1, 0 });
                this._sprite.SetAnimation("gfire" + ammo);
            }
            else
            {
                this._sprite.SetAnimation("empty");
            }            
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
