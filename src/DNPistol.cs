using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    public class DNPistol : Gun {
        SpriteMap _sprite;

        public DNPistol(float xval, float yval) : base(xval, yval) {
            this._ammoType = new AT9mm();
            this._barrelOffsetTL = new Vec2(17f, 3f);
            this._bio = "You should probably find something better.";
            this._editorName = "Pistol";
            this._fireSound = GetPath("sounds/pistol.wav");
            this._fullAuto = false;
            this._fireWait = 1f;
            this._sprite = new SpriteMap(GetPath("sprites/PistolSprite.png"), 16, 10);
            this._sprite.AddAnimation("empty", 0.1f, false, new int[] { 1 });
            this.graphic = this._sprite;
            this.ammo = 12;
            this.center = new Vec2(10f, 4f);
            this.collisionOffset = new Vec2(-9f, -6f);
            this.collisionSize = new Vec2(16f, 11f);            
        }

        public override void OnPressAction() {
            base.OnPressAction();
            if(this.ammo > 0) {
                this._sprite.AddAnimation(("gfire" + ammo ), 0.1f, false, new int[] { 1, 0 });
                this._sprite.SetAnimation("gfire" + ammo);
            } else {
                this._sprite.SetAnimation("empty");
            }            
        }
    }
}
