// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.16
// 

using Colyseus.Schema;

public partial class EntityData : Schema {
	[Type(0, "ref", typeof(Vect3))]
	public Vect3 position = new Vect3();

	[Type(1, "ref", typeof(Quat))]
	public Quat rotation = new Quat();

	[Type(2, "uint8")]
	public uint hp = default(uint);
}

