
namespace Trajekt
{
    interface ISidrenje
    {
        void Utovar(Auto v);
        Auto Istovar();
        int SlobodnaMesta { get; }
    }
}
