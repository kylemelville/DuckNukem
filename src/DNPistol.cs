using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    public class DNPistol : Gun {
        SpriteMap _sprite;

        public DNPistol(float xval, float yval) : base(xval, yval) {
            this._type = "gun";
            this._editorName = "Pistol";
            this._bio = "You should probably find something better.";
            this._sprite = new SpriteMap(GetPath("sprites/DNPistol.png"), 16, 10);
            this._sprite.AddAnimation("empty", 0.1f, false, new int[] { 1 });
            this.graphic = this._sprite;
            this._fireSound = GetPath("sounds/DNPistol.wav");
            this._ammoType = new AT9mm();
            this.ammo = 12;
            this._fullAuto = false;
            this._fireWait = 1f;
            this._barrelOffsetTL = new Vec2(17f, 3f);            
            this.center = new Vec2(10f, 4f);
            this.collisionOffset = -1 * this.center;
            this.collisionSize = new Vec2(this.graphic.width, this.graphic.height);
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
