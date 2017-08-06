using DuckGame;

namespace DuckNukem.src {
    [EditorGroup("Duck Nukem")]

    class DNPipeBomb : Gun {
        public DNPipeBomb(float xval, float yval) : base(xval, yval) {
            this._type = "gun";
            this._editorName = "Pipe Bomb";
            this._bio = "To toss a bomb, press FIRE. To blow up the bomb, juse press FIRE again.";
            this.graphic = new Sprite(GetPath("sprites/DNPipeBomb.png"));
            this._ammoType = new ATShrapnel();
            this.ammo = 5;
            this._fullAuto = false;
            this._fireWait = 5f;
            this.center = new Vec2(this.graphic.width / 2, this.graphic.height / 2);
            this.collisionOffset = -1 * this.center;
            this.collisionSize = new Vec2(this.graphic.width, this.graphic.height);
            this._holdOffset = new Vec2(2f, 1f);
            this._barrelOffsetTL = new Vec2(this.graphic.width, this.graphic.height / 2 + 1);
            //example comment
        }

        private ATGrenade grenade;
        public override void OnPressAction() {
            if(this.grenade == null) {
                this.grenade = new ATGrenade();
                this.Fire(); //gonna have to implement my own so i can control reference
            } else {
                
            }
        }

        public override void Fire() {
            if (!this.loaded)
                return;
            this.firedBullets.Clear();
            if (this.ammo > 0 && this._wait == 0.0) {
                for (int index = 0; index < this._numBulletsPerFire; ++index) {
                    if (!this.receivingPress) {
                        Bullet bullet = this._ammoType.FireBullet(this.Offset(this.barrelOffset), this.owner, angle, this);
                        if (Network.isActive && this.isServerForObject) {
                            this.firedBullets.Add(bullet);
                            if (this.duck != null && this.duck.profile.connection != null)
                                bullet.connection = this.duck.profile.connection;
                        }
                    }
                    ++this.bulletFireIndex;
                }
                this.loaded = false;
                this.Reload(true);
                this.firing = true;
                this._wait = this._fireWait;
                this.PlayFireSound();
                if (this.owner == null) {
                    Vec2 vec2 = this.barrelVector * Rando.Float(1f, 3f);
                    vec2.y += Rando.Float(2f);
                    this.hSpeed -= vec2.x;
                    this.vSpeed -= vec2.y;
                }
            } else {
                if (this.ammo > 0 || this._wait != 0.0)
                    return;
                this.DoAmmoClick();
                this._wait = this._fireWait;
            }
        }
    }
}